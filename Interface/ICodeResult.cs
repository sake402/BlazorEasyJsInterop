using System;
using System.Collections.Generic;
using System.Text;

namespace LivingThing.TCCS.Interface
{
    public interface ICodeResult:ICode
    {
        string VariableName { get; }
    }
}
