using System;
using System.Collections.Generic;
using System.Text;

namespace LivingThing.TCCS.Interface
{
    public interface IInstanceInitializerScope:IGeneratorScope
    {
        bool IsPropertyInitialization { get; }
        string PropertyAssignedName { get; }
    }
}
