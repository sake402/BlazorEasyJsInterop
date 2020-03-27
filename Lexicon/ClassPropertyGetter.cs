//using LivingThing.TCCS.Interface;
//using LivingThing.TCCS.Scopes;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace LivingThing.TCCS.Lexicon
//{
//    internal class ClassPropertyGetter : CodeConstruct, ICodeResult
//    {
//        public ClassPropertyGetter(string propertyName, GeneratorScope scope) : base(scope, null, null)
//        {
//            Name = propertyName;
//        }

//        string Name;

//        public override string ToString()
//        {
//            return $"var {VariableName} = this.{Name}";
//        }
//    }
//}
