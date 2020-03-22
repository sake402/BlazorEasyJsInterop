using System;
using System.Collections.Generic;
using System.Text;

namespace LivingThing.TCCS.Interface
{
    public interface ITypedGeneratorScope:IGeneratorScope
    {
        Type ScopeType { get; }
    }
}
