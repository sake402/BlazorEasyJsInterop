using LivingThing.TCCS.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LivingThing.TCCS.Interface
{
    public interface IGeneratorScope : ICode
    {
        IGenerator Generator { get; }
        IList<ICode> Codes { get; }
        IGeneratorScope BeginScope(bool save = false);
        IGeneratorScope ForLoop(string name, object start, object step, object limit);
        TDefinition Literal<TDefinition>(string code, params object[] parameters) where TDefinition : class;
        void If(string expression, Action<IGeneratorScope> scopeBuilder, params object[] parameters);
        void ElseIf(string expression, Action<IGeneratorScope> scopeBuilder, params object[] parameters);
        void Else(Action<IGeneratorScope> scopeBuilder);
        ParameterBag ParameterBag { get; }
        TDefinition GetDefinition<TDefinition>(params object[] parameters) where TDefinition : class;
        TDefinition Instantiate<TDefinition>(Action<IGeneratorScope, TDefinition> initialize, string name = null, bool propertyOnly = false) where TDefinition : class;
        //TDefinition PropertyInitializer<TDefinition>(Action<IGeneratorScope, TDefinition> initialize, string name = null) where TDefinition : class;
        void Return<TDefinition>(TDefinition definition) where TDefinition : class;
    }

    public interface IGeneratorScope<TParameter> : IGeneratorScope, IDisposable where TParameter:class
    {
        Task<TParameter> Execute(TParameter parameter = default, ParameterBag bag = null, bool save = false); 
    }
}
