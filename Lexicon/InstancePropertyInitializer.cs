using LivingThing.TCCS.Interface;
using LivingThing.TCCS.Scopes;
using System;
using System.Linq;
using System.Reflection;

namespace LivingThing.TCCS.Lexicon
{
    internal class InstancePropertyInitializer : CodeConstruct, ICodeResult
    {
        public InstancePropertyInitializer(GeneratorScope generatorScope, Type type, string instanceName) :
            base(generatorScope, null, null)
        {
            Type = type;
            variableName = instanceName;
        }

        Type Type { get; }

        public override ICodeConstruct Navigate(MethodInfo method, object[] parameters)
        {
            if (method.Name.StartsWith("set_"))
            {
                var name = method.Name.Replace("set_", "");
                if (Scope is InstanceInitializerScope iScope)
                {
                    if (Scope.Codes.Any(code => code is InstanceInitializerScope scope && scope.PropertyAssignedName == name))
                        return new Nop(Scope);
                }
                return new PropertyInitializer(Scope, this, method, parameters);
            }
            throw new InvalidOperationException("Only property set operation allowed in this scope.");
        }

        public override string ToString()
        {
            return "";
        }
    }
}