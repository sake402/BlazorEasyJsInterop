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
            var parameters = GetParameters();
            if (Method.Name == "set_Item")
            {
                var key = Scope.ParameterBag[parameters[0].ToString()];
                //Scope.ParameterBag.Remove(parameters[0].ToString());
                return $"\"{key}\" : {parameters[1]}";
            }
            else
            {
                return $"{Method.Name.Replace("set_", "")} : {parameters[0]}";
            }
        }
    }
}
