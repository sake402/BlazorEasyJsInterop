using LivingThing.TCCS.Interface;
using LivingThing.TCCS.Scopes;
using System.Reflection;

namespace LivingThing.TCCS.Lexicon
{
    internal class PropertyInitializer : CodeConstruct, IParameterized
    {
        public PropertyInitializer(GeneratorScope scope, CodeConstruct from, MethodInfo method, object[] parameters) : base(scope, from, parameters)
        {
            Method = method;
            //parameterName = Method.Name.Replace("set_", "");
        }

        MethodInfo Method { get; }
        public override string ToString()
        {
            if (From is InstancePropertyInitializer)
            {

            }
            return $"{Method.Name.Replace("set_", "")} : {GetParameters()[0]}";
        }
    }
}
