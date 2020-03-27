using LivingThing.TCCS.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivingThing.TCCS.Scopes
{
    internal class IfScope : GeneratorScope
    {
        public IfScope(Generator generator, GeneratorScope parentScope, string expression, params object[] parameters) : base(generator, false, parentScope, parameters)
        {
            Expression = expression;
        }

        string Expression { get; }

        public override string ToString()
        {
            var parameters = GetParameters();
            var expression = string.Format(Expression, parameters);
            return $"if ({expression})\r\n{{\r\n{base.ToString()}\r\n}}";
        }
    }
}
