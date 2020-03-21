using LivingThing.TCCS.Scopes;

namespace LivingThing.TCCS.Lexicon
{
    internal class LiteralCode : CodeConstruct
    {
        public LiteralCode(GeneratorScope scope, string code) : base(scope, null, null)
        {
            Code = code;
        }

        string Code { get; }
        public override string ToString()
        {
            return Code;
        }
    }
}
