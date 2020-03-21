using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace LivingThing.TCCS.Core
{
    public class GeneratorOptions
    {
        public Func<MethodInfo, string> MethodNameFormatter { get; set; }
        public bool DisableParameterBag { get; set; }
    }
}
