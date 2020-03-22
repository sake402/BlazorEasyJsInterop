using LivingThing.TCCS.Scopes;
using System;

namespace LivingThing.TCCS.Lexicon
{
    internal class ClassDefinition : CodeConstruct
    {
        public ClassDefinition(GeneratorScope generatorScope, Type type, string classCreator, object[] paramaters):base(generatorScope, null, paramaters)
        {
            Type = type;
            ClassCreator = classCreator;
        }

        Type Type { get; }
        string ClassCreator { get; }

        public override string ToString()
        {
            var creator = string.Format(ClassCreator, GetParameters());
            return $"var {VariableName} = {creator}";
        }
    }
}
