using LivingThing.TCCS.Interface;
using LivingThing.TCCS.Scopes;
using System.Reflection;

namespace LivingThing.TCCS.Lexicon
{
    internal class PropertyGetter : CodeConstruct, ICodeResult
    {
        public PropertyGetter(GeneratorScope scope, CodeConstruct from, MethodInfo method, object[] parameters) : base(scope, from, parameters)
        {
            Method = method;
        }

        MethodInfo Method { get; }
        public override string ToString()
        {
            return $"var {VariableName} = {From.VariableName}.{Method.Name.Replace("get_", "")}";
        }
    }
}
