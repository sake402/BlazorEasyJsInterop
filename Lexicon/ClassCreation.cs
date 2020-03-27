using LivingThing.TCCS.Interface;
using LivingThing.TCCS.Scopes;
using System;

namespace LivingThing.TCCS.Lexicon
{
    internal class ClassCreation : CodeConstruct, ICodeResult
    {
        public ClassCreation(GeneratorScope generatorScope, Type type, string classCreator, params object[] paramaters)
            :base(generatorScope, null, paramaters)
        {
            Type = type;
            ClassCreator = classCreator;
        }

        Type Type { get; }
        string ClassCreator { get; }

        public override string ToString()
        {
            var creator = string.Format(ClassCreator, GetParameters());
            return $"{VariableDeclaration} = {creator}";
        }
    }
}
