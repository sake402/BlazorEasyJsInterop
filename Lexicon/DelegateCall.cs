using LivingThing.TCCS.Scopes;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivingThing.TCCS.Lexicon
{
    internal class DelegateCall : CodeConstruct
    {
        public DelegateCall(GeneratorScope scope, CodeConstruct from, object[] parameters) : base(scope, from, parameters)
        {
        }

        public override string ToString()
        {
            var parameters = GetParameters();
            var param = string.Join(", ", parameters);
            return $"{VariableDeclaration} = {From.VariableName}({param})";
        }
    }
}
