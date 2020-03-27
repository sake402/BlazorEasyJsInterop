using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using LivingThing.TCCS.Attributes;
using LivingThing.TCCS.Core;
using LivingThing.TCCS.Interface;
using LivingThing.TCCS.Lexicon;

namespace LivingThing.TCCS.Scopes
{
    internal class GeneratorScope : CodeConstruct, IGeneratorScope
    {
        public Generator Generator { get; }
        public IList<GeneratorScope> ChildScopes { get; } = new List<GeneratorScope>();
        public ParameterBag ParameterBag { get; private set; }
        public IList<ICode> Codes { get; } = new List<ICode>();

        IGenerator IGeneratorScope.Generator => Generator;

        public GeneratorScope(Generator generator, bool save, GeneratorScope parentScope, params object[] parameters):base(parentScope, null, parameters)
        {
            Generator = generator;
            ParameterBag = parentScope?.ParameterBag ?? new ParameterBag(generator.Options?.DisableParameterBag ?? false);
            generator.Scopes.Push(this);
            if (parentScope != null)
            {
                parentScope.ChildScopes.Add(this);
            }
        }

        public TDefinition GetDefinition<TDefinition>(params object[] parameters) where TDefinition : class
        {
            var nameAttr = typeof(TDefinition).GetCustomAttribute<NameAttribute>();
            string entryCode = nameAttr?.Name;//?? typeof(TDefinition).Name;
            if (entryCode == null)
            {
                string code = "";
                for (int i = 0; i < parameters.Length; i++)
                {
                    code += $"{{{i}}}";
                    if (i != parameters.Length - 1)
                    {
                        code += ", ";
                    }
                }
                var type = typeof(TDefinition);
                var typeName = type.FullName.Replace(type.Namespace + ".", "").Replace("+", ".");
                entryCode = $"new {typeName}({code})";
            }
            return new Interceptor<TDefinition>(this, new ClassCreation(this, typeof(TDefinition), entryCode, parameters)).GetProxyAsync(parameters);
        }

        public TDefinition Instantiate<TDefinition>(Action<IGeneratorScope, TDefinition> init, string name = null, bool propertyOnly = false) where TDefinition : class
        {
            if (name == null)
            {
                name = Util.Utility.GenerateVariableName();
            }
            var nameAttr = typeof(TDefinition).GetCustomAttribute<NameAttribute>();
            string entryCode = nameAttr?.Name ?? "{{ }}";
            using (var newScope = new InstanceInitializerScope<TDefinition>(Generator, typeof(TDefinition), name, entryCode, this, propertyOnly))
            {
                //ICodeConstruct target = null;
                //if (propertyOnly)
                //{
                //    target = new InstancePropertyInitializer<TDefinition>(newScope, typeof(TDefinition), name);
                //}
                //else
                //{
                //    target = new InstanceInitializer(newScope, typeof(TDefinition), name, entryCode, new object[] { });
                //}
                var definition = new Interceptor<TDefinition>(this, newScope).GetProxy(newScope);
                init(newScope, definition);
                return definition;
            }
        }

        public TDefinition PropertyInitializer<TDefinition>(Action<IGeneratorScope, TDefinition> initialize, string name = null) where TDefinition : class
        {
            return Instantiate<TDefinition>(initialize, name, true);
        }

        public void Return<TDefinition>(TDefinition definition) where TDefinition : class
        {
            var result = Generator.GetDefinition(definition).Interceptor.Target as ICodeResult;
            new Return(this, result);
        }

        public IGeneratorScope BeginScope(bool save = false)
        {
            return new GeneratorScope(Generator, save, this);
        }

        public IGeneratorScope ForLoop(string name, object start, object step, object limit)
        {
            var code = new ForLoopScope(name, start, step, limit, this);
            return code;
        }

        public override string ToString()
        {
            string combinedCode = "";
            int i = 0;
            foreach(var code in Codes)
            {
                var scode = code.ToString();
                if (!string.IsNullOrEmpty(scode))
                {
                    combinedCode += scode;
                    if (!(code is IGeneratorScope) || (code is IInstanceInitializerScope))
                    {
                        combinedCode += ";";
                    }
                    if (i != Codes.Count - 1)
                    {
                        combinedCode += "\r\n";
                    }
                }
                i++;
            }
            return combinedCode;
            //return string.Join(";\r\n", Codes.Select(t => t.ToString()).Where(c => !string.IsNullOrEmpty(c)));
        }

        public T Literal<T>(string code, params object[] parameters) where T : class
        {
            var literal = new LiteralCode(this, code, parameters);
            var definition = new Interceptor<T>(this, literal).GetProxy(null);
            return definition;
        }

        public void If(string expression, Action<IGeneratorScope> scopeBuilder, params object[] parameters)
        {
            var scope = new IfScope(Generator, this, expression, parameters);
            scopeBuilder(scope);
        }

        public void ElseIf(string expression, Action<IGeneratorScope> scopeBuilder, params object[] parameters)
        {
            var scope = new ElseIfScope(Generator, this, expression, parameters);
            scopeBuilder(scope);
        }

        public void Else(Action<IGeneratorScope> scopeBuilder)
        {
            var scope = new ElseScope(Generator, this);
            scopeBuilder(scope);
        }
    }

    internal class GeneratorScope<TParameter> : GeneratorScope, IGeneratorScope<TParameter> where TParameter:class
    {
        bool _save;
        bool _stored;

        public GeneratorScope(Generator generator, bool save, GeneratorScope parentScope) : base(generator, save, parentScope)
        {
            _save = save;
        }

        internal Task Store()
        {
            var code = ToString();
            _stored = true;
            return Generator.Executor.ExecuteAsync<object>("window.lt.storeProcedure", new object[] {
                Generator.GetHashCode().ToString(),
                GetHashCode().ToString(),
                code,
                ParameterBag.Parameters
            });
        }

        public Task<TParameter> Execute(TParameter parameter = default, ParameterBag bag = null, bool save = false)
        {
            if (_stored)
            {
                return ExecuteProcedure(parameter, bag);
            }
            var code = ToString();
            if (bag != null)
            {
                bag = bag.Clone(parameter);
            }
            else
            {
                bag = new ParameterBag(parameter);
            }
            string generatorKey = null;
            string scopeKey = null;
            if (save)
            {
                generatorKey = Generator.GetHashCode().ToString();
                scopeKey = GetHashCode().ToString();
                _stored = true;
            }
            return Generator.Executor.ExecuteAsync<TParameter>("window.lt.execute", new object[] {
                    code,
                    bag.Parameters,
                    generatorKey,
                    scopeKey
                });
        }

        Task<TParameter> ExecuteProcedure(TParameter parameter = default, ParameterBag bag = null)
        {
            if (bag != null)
            {
                bag = bag.Clone(parameter);
            }
            else
            {
                bag = new ParameterBag(parameter);
            }
            return Generator.Executor.ExecuteAsync<TParameter>("window.lt.executeStored", new object[] {
                Generator.GetHashCode().ToString(),
                GetHashCode().ToString(),
                bag.Parameters,
            });
        }

        public virtual void Dispose()
        {
            if (GetType() == typeof(GeneratorScope))
            {
                Execute(null, null, _save);
            }
            Generator.Scopes.Pop();
        }
    }

}
