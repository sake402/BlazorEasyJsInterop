using LivingThing.TCCS.Interface;
using LivingThing.TCCS.Scopes;

namespace LivingThing.TCCS.Lexicon
{
    internal class LiteralCode : CodeConstruct, ICodeResult
    {
        public LiteralCode(GeneratorScope scope, string code) : base(scope, null, null)
        {
            Code = code;
        }

        string Code { get; }
        public override string ToString()
        {
            return $"var {VariableName} = {Code}";
        }
    }
}
