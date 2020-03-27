using LivingThing.TCCS.Interface;
using LivingThing.TCCS.Scopes;

namespace LivingThing.TCCS.Lexicon
{
    internal class LiteralCode : CodeConstruct, ICodeResult
    {
        public LiteralCode(GeneratorScope scope, string code, params object[] parameters) : base(scope, null, parameters)
        {
            Code = code;
        }

        string Code { get; }
        public override string ToString()
        {
            var code = string.Format(Code, GetParameters());
            if (HasVariableName)
                return $"var {VariableName} = {code}";
            else
                return code;
        }
    }
}
