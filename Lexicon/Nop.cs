using LivingThing.TCCS.Scopes;

namespace LivingThing.TCCS.Lexicon
{
    internal class Nop : CodeConstruct
    {
        public Nop(GeneratorScope scope) : base(scope, null, null)
        {
        }

        public override string ToString()
        {
            return "";
        }
    }
}
