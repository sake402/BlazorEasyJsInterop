using LivingThing.TCCS.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LivingThing.TCCS.Interface
{
    public interface IGenerator
    {
        IGeneratorScope CurrentScope { get; }
        //IDictionary<object, DefinitionContext> Definitions { get; }
        //Task<TDefinition> GetDefinition<TDefinition>(params object[] parameters) where TDefinition : class, IDefinition;
        //IDisposable Batch(Action<IGenerator> batchBuilder);
    }
}
