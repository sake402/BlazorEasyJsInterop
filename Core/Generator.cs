using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LivingThing.TCCS.Interface;
using LivingThing.TCCS.Lexicon;
using LivingThing.TCCS.Scopes;

namespace LivingThing.TCCS.Core
{
    public class Generator: IGenerator
    {
        public IScriptExecutor Executor { get; }
        public GeneratorOptions Options { get; }

        internal Stack<GeneratorScope> Scopes = new Stack<GeneratorScope>();
        internal GeneratorScope CurrentScope
        {
            get
            {
                if (Scopes.Count == 0)
                {
                    Scopes.Push(new GeneratorScope(this, false, null));
                }
                return Scopes.Peek();
            }
        }

        IGeneratorScope IGenerator.CurrentScope => CurrentScope;

        public IGeneratorScope<TParameter> BeginScope<TParameter>(bool save = false) where TParameter:class
        {
            var scope = new GeneratorScope<TParameter>(this, save, null);
            return scope;
        }

        public async Task<IGeneratorScope<TParameter>> Function<TParameter>(Func<IGeneratorScope, IScopeParameterBag<TParameter>, Task> functionBuilder) where TParameter : class
        {
            var scope = new GeneratorScope<TParameter>(this, false, null);
            await functionBuilder(scope, new ScopeParameterBag<TParameter>(scope));
            _ = scope.Store();
            Scopes.Push(scope);
            return scope;
        }

        public async Task<IClassGeneratorScope<TConstructorParameter>> Class<TConstructorParameter>(string name, Func<IClassGeneratorScope/*, IScopeParameterBag<TParameter>*/, Task> classBuilder) where TConstructorParameter:class
        {
            var scope = new ClassGeneratorScope<TConstructorParameter>(name, this, null);
            await classBuilder(scope);
            _ = scope.Store();
            Scopes.Push(scope);
            return scope;
        }

        public Generator(IScriptExecutor executor, GeneratorOptions options = null)
        {
            Executor = executor;
            Options = options;
        }

        IDictionary<GeneratorScope, IList<DefinitionContext>> Definitions { get; } = new Dictionary<GeneratorScope, IList<DefinitionContext>>();

        internal DefinitionContext AddDefinition(GeneratorScope scope, IScriptInterceptor interceptor, object definition)
        {
            if (!Definitions.ContainsKey(scope))
            {
                Definitions[scope] = new List<DefinitionContext>();
            }
            var defs = Definitions[scope];
            var def = new DefinitionContext() { Interceptor = interceptor, Defined = definition };
            defs.Add(def);
            return def;
        }

        internal DefinitionContext GetDefinition(object definition)
        {
            return Definitions.Values.SelectMany(v=> v).SingleOrDefault(def => def.Defined == definition);
        }

        //public virtual Task<TDefinition> GetDefinition<TDefinition>(params object[] parameters) where TDefinition : class, IDefinition
        //{
        //    if (Scopes.Count == 0)
        //    {
        //        BeginScope();
        //    }
        //    return CurrentScope.GetDefinition<TDefinition>(parameters);
        //}

        //public void Return<TDefinition>(TDefinition definition) where TDefinition : class, IDefinition
        //{
        //    CodeDefinition def = definition as CodeDefinition;
        //    new Return(def.Interceptor.Method);
        //}

        //public void SetParameter<TDefinition>(TDefinition definition, params object[] parameters) where TDefinition : class, IDefinition
        //{
        //    CodeDefinition def = definition as CodeDefinition;
        //    for (int i = 0; i < parameters.Length; i++)
        //    {
        //        ParameterBag.Set(def.Interceptor.Method, i, parameters[i]);
        //    }
        //}
    }
}
