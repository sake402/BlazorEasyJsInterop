using LivingThing.TCCS.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivingThing.TCCS.Scopes
{
    internal class ElseScope : GeneratorScope
    {
        public ElseScope(Generator generator, GeneratorScope parentScope) : base(generator, false, parentScope)
        {
        }

        public override string ToString()
        {
            return $"else\r\n{{\r\n{base.ToString()}\r\n}}";
        }
    }
}
