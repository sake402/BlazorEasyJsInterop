using System;
using System.Collections.Generic;
using System.Text;

namespace LivingThing.TCCS.Interface
{
    public interface IFunctionGeneratorScope<TParameter> :IGeneratorScope<TParameter> where TParameter:class
    {
        string Name { get; }
    }
}
