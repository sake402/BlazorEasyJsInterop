using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LivingThing.TCCS.Interface;
using LivingThing.TCCS.Scopes;

namespace LivingThing.TCCS.Core
{
    public class Generator: IGenerator
    {
        public IScriptExecutor Executor { get; }
        public GeneratorOptions Options { get; }
        internal ParameterBag ParameterBag { get; }

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

        public IGeneratorScope BeginScope(bool save = false)
        {
            var scope = new GeneratorScope(this, save, null);
            return scope;
        }

        public async Task<IGeneratorScope> StoredProcedure(Func<IGeneratorScope, Task> procedureBuilder)
        {
            var scope = new GeneratorScope(this, false, null);
            await procedureBuilder(scope);
            _ = scope.Store();
            Scopes.Push(scope);
            return scope;
        }

        public Generator(IScriptExecutor executor, GeneratorOptions options = null)
        {
            Executor = executor;
            Options = options;
            ParameterBag = new ParameterBag(options?.DisableParameterBag ?? false);
        }

        internal IDictionary<object, DefinitionContext> Definitions { get; } = new Dictionary<object, DefinitionContext>();

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
