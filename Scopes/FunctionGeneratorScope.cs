using LivingThing.TCCS.Core;
using LivingThing.TCCS.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivingThing.TCCS.Scopes
{
    internal class FunctionGeneratorScope<TParameter> : GeneratorScope<TParameter>, IFunctionGeneratorScope<TParameter>, ICode where TParameter : class
    {
        public FunctionGeneratorScope(string name, Generator generator, GeneratorScope parentScope) : base(generator, false, parentScope)
        {
            Name = name;
        }

        public string Name { get; }

        public override string ToString()
        {
            return $"{Name}(p, x)\r\n{{\r\n{base.ToString()}\r\n}}";
        }
    }
}
