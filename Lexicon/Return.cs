using LivingThing.TCCS.Interface;
using LivingThing.TCCS.Scopes;

namespace LivingThing.TCCS.Lexicon
{
    internal class Return:CodeConstruct
    {
        public Return(GeneratorScope scope, ICodeResult result) : base(scope, null, null)
        {
            Construct = result;
        }

        ICodeResult Construct { get; }

        public override string ToString()
        {
            return $"return {Construct.VariableName}";
        }
    }
}
