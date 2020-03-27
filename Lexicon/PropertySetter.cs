using LivingThing.TCCS.Interface;
using LivingThing.TCCS.Scopes;
using System;
using System.Collections;
using System.Linq;
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
        public override Type[] ParameterTypes => Method.GetParameters().Select(m => m.ParameterType).ToArray();

        public override string ToString()
        {
            var parameters = GetParameters();
            if (Method.Name == "set_Item")
            {
                return $"{From.VariableName}[{parameters[0]}] = {parameters[1]}";
            }
            else
            {
                return $"{From.VariableName}.{Method.Name.Replace("set_", "")} = {parameters[0]}";
            }
        }
    }
}
