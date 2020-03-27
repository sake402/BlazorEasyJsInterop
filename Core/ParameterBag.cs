using LivingThing.TCCS.Definitions.Util;
using LivingThing.TCCS.Interface;
using LivingThing.TCCS.Lexicon;
using LivingThing.TCCS.Scopes;
using LivingThing.TCCS.Util;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace LivingThing.TCCS.Core
{
    public class ParameterBag
    {
        public ParameterBag(Dictionary<string, object> parameters)
        {
            Parameters = parameters;
        }

        public ParameterBag(object parameters)
        {
            if (parameters != null)
            {
                foreach (var property in parameters.GetType().GetProperties())
                {
                    Parameters[property.Name] = property.GetValue(parameters).UnWrap();
                }
            }
        }

        bool _disabled;
        public ParameterBag(bool disabled = false)
        {
            _disabled = disabled;
        }

        public Dictionary<string, object> Parameters { get; } = new Dictionary<string, object>();

        public object this[string key]
        {
            get
            {
                var kkey = key.Substring(2);// remove p.;
                if (Parameters.ContainsKey(kkey))
                {
                    return Parameters[kkey];
                }
                return null;
            }
        }

        public void Remove(string key)
        {
            var kkey = key.Substring(2);// remove p.;
            if (Parameters.ContainsKey(kkey))
            {
                Parameters.Remove(kkey);
            }
        }

        class NameParameter
        {
            public string Name { get; set; }
            public object Value { get; set; }
            public Type Type { get; set; }
            public override string ToString()
            {
                return $"{Name}:({Type})={Value}";
            }
        }

        IList<NameParameter> namedParameters = new List<NameParameter>();
        public T NamedParameter<T>(string name, T initialValue)
        {
            namedParameters.Add(new NameParameter() { Name = name, Value = initialValue, Type = typeof(T) });
            return initialValue;
        }

        public T ExportVariable<T>(IGeneratorScope scope, string name, T value)
        {
            var _scope = scope as GeneratorScope;
            var definition = _scope.Generator.GetDefinition(value);
            if (definition != null)
            {
                var target = definition.Interceptor.Target;
                if (target is CodeConstruct result)
                {
                    if (name.EndsWith("]"))
                    {
                        var objectName = name.Split(new char[] { '[' })[0];
                        scope.Literal<object>($"(x.{objectName} = x.{objectName} || {{{{ }}}})");
                        //move literal above result
                        var lastCode = scope.Codes.Last() as LiteralCode;
                        scope.Codes.Remove(lastCode);
                        var resultIndex = scope.Codes.IndexOf(result);
                        scope.Codes.Insert(resultIndex, lastCode);
                    }
                    result.VariableName = "x." + name;
                }
            }
            return value;
        }

        public T ImportVariable<T>(IGeneratorScope scope, string name) where T:class
        {
            return scope.Literal<T>("x." + name);
        }

        bool IsAssignable(Type lhs, Type rhs, object rhsValue)
        {
            if (lhs?.IsAssignableFrom(rhs)??false)
                return true;
            if (typeof(Union).IsAssignableFrom(lhs))
            {
                var union = rhsValue as Union;
                var generics = lhs.GetGenericArguments();
                return generics.Any(g => IsAssignable(g, rhs, union?.Value));
            }
            if (typeof(TypeAlias).IsAssignableFrom(lhs))
            {
                var alias = rhsValue as TypeAlias;
                var aliasedType = lhs.BaseType.GetGenericArguments()[0];
                return IsAssignable(aliasedType, rhs, alias?.Value);
            }
            if (typeof(Enumerated).IsAssignableFrom(lhs))
            {
                var @enum = rhsValue as Enumerated;
                var enumeratedType = lhs.BaseType.GetGenericArguments()[0];
                return IsAssignable(enumeratedType, rhs, @enum?.Value);
            }
            return false;
        }

        string Put(IParameterized setter, int index, object value)
        {
            if (_disabled)
            {
                if (value is string str)
                {
                    return "\"" + str.Replace("\"", "\\\"") + "\"";
                }
                if (value is bool b)
                {
                    return b ? "true" : "false";
                }
                return value?.ToString() ?? "null";
            }
            string key;
            var np = namedParameters.FirstOrDefault(p =>
            {
                Type type = null;
                if (index >= 0)
                {
                    type = setter.ParameterTypes[index];
                }
                if (type == null)
                {
                    type = value?.GetType();
                }
                return IsAssignable(type, p.Type, value) && (p.Value == null || (value?.Equals(p.Value) ?? false));
            });
            if (np != null)
            {
                key = np.Name;
                namedParameters.Remove(np);
            }
            else
            {
                key = setter.ParameterNamePrefix + (index >= 0 ? "_" + index : "");
            }
            key = key.Replace(".", "_").Replace("[", "_").Replace("]", "_");
            Parameters[key] = value;
            return $"p.{key}";
        }

        public string Set(IParameterized setter, int index, object value)
        {
            if (value is string pk && pk.StartsWith("p.")) //identify already set parameter name
                return pk;
            if (value is string xv && xv.StartsWith("x.")) //identify exported variable
                return xv;
            if (value is string lv && lv.StartsWith("$")) //identify local variable name
                return lv;
            if (value is IEnumerable array && value.GetType() != typeof(string))
            {
                bool hasLocalVariable = false;
                foreach (var item in array)
                {
                    if (item is string str)
                    {
                        if (str.StartsWith("$") || str.StartsWith("x."))
                        {
                            hasLocalVariable = true;
                            break;
                        }
                    }
                }
                if (hasLocalVariable)
                {
                    List<object> objs = new List<object>();
                    foreach (var item in array)
                    {
                        if (item is string str && (str.StartsWith("$")|| str.StartsWith("x.")))
                        {
                            objs.Add(str);
                        }
                        else
                        {
                            objs.Add(Put(setter, index, item));
                        }
                    }
                    return "[" + string.Join(", ", objs.Select(o => o.ToString())) + "]";
                }
            }
            return Put(setter, index, value);
        }

        public string SetMany(IParameterized setter, params object[] parameters)
        {
            if (_disabled)
            {
                return "[" + string.Join(", ", parameters.Select(parameter =>
                {
                    if (parameter is string str)
                    {
                        return "\"" + str.Replace("\"", "\\\"") + "\"";
                    }
                    if (parameter is bool b)
                    {
                        return b ? "true" : "false";
                    }
                    return parameter?.ToString() ?? "null";
                })) + "]";
            }
            var key = setter.ParameterNamePrefix;
            Parameters[key] = parameters;
            return $"p.{key}";
        }

        public void SetFor<TDefinition>(TDefinition definition, params object[] parameters) where TDefinition : class
        {
            //CodeDefinition def = definition as CodeDefinition;
            for (int i = 0; i < parameters.Length; i++)
            {
                //Set(def.Interceptor.Target, i, parameters[i]);
            }
        }

        GeneratorScope GetScopeOf<T>(GeneratorScope from)
        {
            if (from is ITypedGeneratorScope tScope && tScope.ScopeType == typeof(T))
            {
                return from;
            }
            foreach(var ch in from.ChildScopes)
            {
                var scope = GetScopeOf<T>(ch);
                if (scope != null)
                    return scope;
            }
            return null;
        }

        public void SetNamed(string parameterName, object value)
        {
            Parameters[parameterName] = value;
        }

        //public void Set<T>(IGeneratorScope scope, Expression<Func<T, object>> path, object value, int index = 0)
        //{
        //    GeneratorScope _scope = GetScopeOf<T>(scope as GeneratorScope);
        //    if (_scope != null)
        //    {
        //        var property
        //    }
        //}

        //public void Set<T>(IGeneratorScope scope, object definition, object value)
        //{
        //    GeneratorScope _scope = scope as GeneratorScope;
        //    var def = _scope.Generator.GetDefinition(definition);
        //    if (def.Interceptor.Target is IParameterized parameterized)
        //    {
        //        Set(parameterized, -1, value);
        //    }
        //}

        public ParameterBag Clone(object overrides = null)
        {
            var newDic = new Dictionary<string, object>(Parameters);
            if (overrides != null)
            {
                foreach(var property in overrides.GetType().GetProperties())
                {
                    newDic[property.Name] = property.GetValue(overrides);
                }
            }
            return new ParameterBag(newDic);
        }

        public override string ToString()
        {
            return string.Join("\r\n", Parameters.Select(kv => $"{kv.Key}:{kv.Value}"));
        }
    }
}
