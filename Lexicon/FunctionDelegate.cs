using LivingThing.TCCS.Interface;
using LivingThing.TCCS.Scopes;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivingThing.TCCS.Lexicon
{
    internal class FunctionDelegate : CodeConstruct, ICodeResult
    {
        public FunctionDelegate(GeneratorScope scope, object @delegate) : base(scope, null, null)
        {
            Delegate = @delegate;
        }

        object Delegate { get; }

        public override string ToString()
        {
            return $"{VariableDeclaration} = function(){{ }}";
        }
    }
}
