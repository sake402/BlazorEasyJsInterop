//using LivingThing.TCCS.Interface;
//using LivingThing.TCCS.Scopes;
//using System;
//using System.Linq;
//using System.Reflection;

//namespace LivingThing.TCCS.Lexicon
//{
//    internal class InstancePropertyInitializer<TDefinition> : CodeConstruct, ICodeResult where TDefinition : class
//    {
//        public InstancePropertyInitializer(InstanceInitializerScope<TDefinition> generatorScope, Type type, string instanceName) :
//            base(generatorScope, null, null)
//        {
//            Type = type;
//            VariableName = instanceName;
//        }

//        Type Type { get; }

//        public override ICodeConstruct Navigate(MethodInfo method, object[] parameters)
//        {
//            if (method.Name.StartsWith("set_"))
//            {
//                var name = method.Name.Replace("set_", "");
//                if (Scope is IInstanceInitializerScope iScope)
//                {
//                    if (Scope.Codes.Any(code => code is IInstanceInitializerScope scope && scope.PropertyAssignedName == name))
//                        return new Nop(Scope);
//                }
//                return new PropertyInitializer(Scope, this, method, parameters);
//            }
//            throw new InvalidOperationException("Only property set operation allowed in this scope.");
//        }

//        string propertyAssignedName;
//        public override void OnAssignedTo(MethodInfo method)
//        {
//            (Scope as InstanceInitializerScope<TDefinition>).PropertyAssignedName = method.Name.Replace("set_", "");
//            base.OnAssignedTo(method);
//        }

//        public override string ToString()
//        {
//            return "";
//        }
//    }
//}