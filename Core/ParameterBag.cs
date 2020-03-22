using LivingThing.TCCS.Interface;
using LivingThing.TCCS.Scopes;
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

        bool _disabled;
        public ParameterBag(bool disabled = false)
        {
            _disabled = disabled;
        }

        public Dictionary<string, object> Parameters { get; } = new Dictionary<string, object>();

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
            var key = setter.ParameterName + (index >= 0 ? "_" + index : "");
            Parameters[key] = value;
            return $"p.{key}";
        }

        public string Set(IParameterized setter, int index, object value)
        {
            if (value is string pk && pk.StartsWith("p.")) //identify already set parameter name
                return pk;
            if (value is string lv && lv.StartsWith("$")) //identify local variable name
                return lv;
            if (value is IEnumerable array && value.GetType() != typeof(string))
            {
                bool hasLocalVariable = false;
                foreach (var item in array)
                {
                    if (item is string str)
                    {
                        if (str.StartsWith("$"))
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
                        if (item is string str && (str.StartsWith("$")/*|| str.StartsWith("p.")*/))
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
            var key = setter.ParameterName;
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

        void Set<T>(IGeneratorScope scope, Expression<Func<T, object>> path, object value, int index = 0)
        {
            GeneratorScope _scope = GetScopeOf<T>(scope as GeneratorScope);
            if (_scope != null)
            {

            }
        }

        public ParameterBag Clone()
        {
            var newDic = new Dictionary<string, object>(Parameters);
            return new ParameterBag(newDic);
        }
    }
}
