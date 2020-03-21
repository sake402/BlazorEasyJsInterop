using LivingThing.TCCS.Interface;
using LivingThing.TCCS.Scopes;
using System;

namespace LivingThing.TCCS.Lexicon
{
    internal class InstanceInitializer : LiteralCode, ICodeResult
    {
        public InstanceInitializer(GeneratorScope generatorScope, Type type, string instanceName, string instanceCreation, object[] paramaters) :
            base(generatorScope, $"var {instanceName} = {(paramaters.Length > 0 ? string.Format(instanceCreation, paramaters) : instanceCreation)}")
        {
            Type = type;
            variableName = instanceName;
        }

        Type Type { get; }
    }
}
