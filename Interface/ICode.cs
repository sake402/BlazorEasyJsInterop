using System;
using System.Collections.Generic;
using System.Text;

namespace LivingThing.TCCS.Interface
{
    public interface ICode
    {
        IGeneratorScope Scope { get; }
    }
}
