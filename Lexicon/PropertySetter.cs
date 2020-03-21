using LivingThing.TCCS.Interface;
using LivingThing.TCCS.Scopes;
using System.Reflection;

namespace LivingThing.TCCS.Lexicon
{
    internal class PropertySetter : CodeConstruct, IParameterized
    {
        public PropertySetter(GeneratorScope scope, CodeConstruct from, MethodInfo method, object[] parameters) : base(scope, from, parameters)
        {
            Method = method;
            //parameterName = Method.Name.Replace("set_", "");
        }

        MethodInfo Method { get; }
        public override string ToString()
        {
            //return $"{Method.Name.Replace("set_", "")} : {GetParameters()[0]}";
            return $"{From.VariableName}.{Method.Name.Replace("set_", "")} = {GetParameters()[0]}";
        }
    }
}
