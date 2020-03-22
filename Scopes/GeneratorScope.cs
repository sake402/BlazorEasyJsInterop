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
    internal class GeneratorScope : IGeneratorScope
    {
        public Generator Generator { get; }
        public GeneratorScope ParentScope { get; }
        public IList<GeneratorScope> ChildScopes { get; } = new List<GeneratorScope>();
        public ParameterBag ParameterBag => Generator.ParameterBag;
        public IList<ICode> Codes { get; } = new List<ICode>();

        IGenerator IGeneratorScope.Generator => Generator;

        public IGeneratorScope Scope => ParentScope;

        bool _save;
        bool _stored;

        public GeneratorScope(Generator generator, bool save, GeneratorScope parentScope)
        {
            Generator = generator;
            _save = save;
            ParentScope = parentScope;
            generator.Scopes.Push(this);
            if (parentScope != null)
            {
                parentScope.ChildScopes.Add(this);
            }
        }

        public Task<TDefinition> GetDefinition<TDefinition>(params object[] parameters) where TDefinition : class
        {
            var nameAttr = typeof(TDefinition).GetCustomAttribute<NameAttribute>();
            string entryCode = nameAttr?.Name ?? typeof(TDefinition).Name;
            return new Interceptor<TDefinition>(Generator, new ClassDefinition(this, typeof(TDefinition), entryCode, parameters)).GetProxyAsync(parameters);
        }

        public TDefinition Instantiate<TDefinition>(Action<IGeneratorScope, TDefinition> init, string name = null, bool propertyOnly = false) where TDefinition : class
        {
            if (name == null)
            {
                name = Util.Utility.GenerateVariableName();
            }
            using (var newScope = new InstanceInitializerScope(Generator, typeof(TDefinition), name, this, propertyOnly))
            {
                Codes.Add(newScope);
                var nameAttr = typeof(TDefinition).GetCustomAttribute<NameAttribute>();
                string entryCode = nameAttr?.Name ?? "{ }";
                ICodeConstruct target = null;
                if (propertyOnly)
                {
                    target = new InstancePropertyInitializer(newScope, typeof(TDefinition), name);
                }
                else
                {
                    target = new InstanceInitializer(newScope, typeof(TDefinition), name, entryCode, new object[] { });
                }
                var definition = new Interceptor<TDefinition>(Generator, target).GetProxy(newScope);
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
            var result = Generator.Definitions[definition].Interceptor.Target as ICodeResult;
            new Return(this, result);
        }

        internal Task Store()
        {
            var code = ToString();
            var key = GetHashCode().ToString();
            _stored = true;
            return Generator.Executor.ExecuteAsync<object>("window.lt.storeProcedure", new object[] {
                    key,
                    code
                });
        }

        public Task<T> Execute<T>(ParameterBag bag = null, bool save = false)
        {
            if (_stored)
            {
                return ExecuteProcedure<T>(bag);
            }
            var code = ToString();
            bag = bag ?? Generator.ParameterBag.Clone();
            string key = null;
            if (save)
            {
                key = GetHashCode().ToString();
                _stored = true;
            }
            return Generator.Executor.ExecuteAsync<T>("window.lt.execute", new object[] {
                    code,
                    bag.Parameters,
                    key
                });
        }

        Task<T> ExecuteProcedure<T>(ParameterBag bag = null)
        {
            bag = bag ?? Generator.ParameterBag.Clone();
            return Generator.Executor.ExecuteAsync<T>("window.lt.executeStored", new object[] {
                    GetHashCode().ToString(),
                    bag.Parameters,
                });
        }

        public virtual void Dispose()
        {
            if (GetType() == typeof(GeneratorScope))
            {
                Execute<object>(null, _save);
            }
            Generator.Scopes.Pop();
        }

        public IGeneratorScope BeginScope(bool save = false)
        {
            return new GeneratorScope(Generator, save, this);
        }

        public IGeneratorScope ForLoop(string name, object start, object step, object limit)
        {
            var code = new ForLoopScope(name, start, step, limit, this);
            Codes.Add(code);
            return code;
        }

        public override string ToString()
        {
            return string.Join(";\r\n", Codes.Select(t => t.ToString()).Where(c => !string.IsNullOrEmpty(c)));
        }

        public T Literal<T>(string code) where T:class
        {
            var literal = new LiteralCode(this, code);
            var definition = new Interceptor<T>(Generator, literal).GetProxy(null);
            return definition;
        }
    }
}
