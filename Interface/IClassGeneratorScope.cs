using LivingThing.TCCS.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LivingThing.TCCS.Interface
{
    public interface IClassGeneratorScope:IGeneratorScope
    {
        Task<IFunctionGeneratorScope<TParameter>> DefineConstructor<TParameter>(Func<IGeneratorScope, IScopeParameterBag<TParameter>, Task> functionBuilder) where TParameter : class;
        IClassPropertyAccessor<TDefinition> DefineProperty<TDefinition>(string name, string initialValue = null) where TDefinition : class;
        IClassPropertyArrayAccessor<TDefinition> DefineArrayProperty<TDefinition>(string name, params TDefinition[] initialMembers) where TDefinition : class;
        IClassDictionaryPropertyAccessor<TDefinition> DefineDictionaryProperty<TDefinition>(string name) where TDefinition:class;
        Task<IFunctionGeneratorScope<TParameter>> DefineFunction<TParameter>(string name, Func<IGeneratorScope, IScopeParameterBag<TParameter>, Task> functionBuilder) where TParameter:class;
    }

    public interface IClassGeneratorScope<TConstructorParameter> : IClassGeneratorScope where TConstructorParameter : class
    {
        Task Execute(TConstructorParameter parameter = default, ParameterBag bag = null);
        Task<TReturn> Call<TParameter, TReturn>(IFunctionGeneratorScope<TParameter> scope, TParameter parameter = default(TParameter), ParameterBag bag = null) where TParameter : class;  
    }
}
