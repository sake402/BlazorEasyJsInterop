using LivingThing.TCCS.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LivingThing.TCCS.Interface
{
    public interface IGeneratorScope:IDisposable, ICode
    {
        IGenerator Generator { get; }
        IList<ICode> Codes { get; }
        IGeneratorScope BeginScope(bool save = false);
        IGeneratorScope ForLoop(string name, object start, object step, object limit);
        ParameterBag ParameterBag { get; }
        Task<TDefinition> GetDefinition<TDefinition>(params object[] parameters) where TDefinition : class;
        TDefinition Instantiate<TDefinition>(Action<IGeneratorScope, TDefinition> initialize, string name = null, bool propertyOnly = false) where TDefinition : class;
        void Return<TDefinition>(TDefinition definition) where TDefinition : class;
        Task<T> Execute<T>(ParameterBag bag = null, bool save = false);
    }
}
