using LivingThing.TCCS.Core;
using LivingThing.TCCS.Interface;
using LivingThing.TCCS.Lexicon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace LivingThing.TCCS.Scopes
{
    internal class InstanceInitializerScope<TParameter> : GeneratorScope<TParameter>, IInstanceInitializerScope, ITypedGeneratorScope/*, IWatchDefinition*/, ICodeResult where TParameter:class
    {
        public InstanceInitializerScope(Generator generator, Type instanceType, string instanceName, string instanceCreation, GeneratorScope parentScope, bool onlyProperyInitialization) 
            : base(generator, false, parentScope)
        {
            InstanceType = instanceType;
            VariableName = instanceName;
            //InstanceCreation = instanceCreation;
            _onlyProperyInitialization = onlyProperyInitialization;
            if (!_onlyProperyInitialization)
            {
                LiteralCode lt = new LiteralCode(this, $"{instanceCreation}");
                lt.VariableName = VariableName;
            }
        }


        Type InstanceType { get; }
        //string InstanceName { get; }
        //string InstanceCreation { get; }
        bool _onlyProperyInitialization;
        public bool IsPropertyInitialization => _onlyProperyInitialization;

        public override string ToString()
        {
            if (_onlyProperyInitialization)
            {
                if (Scope is IInstanceInitializerScope)
                {
                    return $"{PropertyAssignedName} : {{ { string.Join(", ", Codes.Select(t => t.ToString()).Where(c=> !string.IsNullOrEmpty(c))) } }}";
                }
                else
                {
                    return $"var {VariableName} = {{ { string.Join(", ", Codes.Select(t => t.ToString()).Where(c => !string.IsNullOrEmpty(c))) } }}";
                }
            }
            else
                return $"var {VariableName} = (function()\r\n{{\r\n{base.ToString()};\r\nreturn {VariableName};\r\n}})()";
        }

        public string PropertyAssignedName { get; set; }

        //public string VariableName => InstanceName;

        public Type ScopeType => InstanceType;

        public override void OnAssignedTo(MethodInfo method)
        {
            PropertyAssignedName = method.Name.Replace("set_", "");
            base.OnAssignedTo(method);
        }


        public override ICodeConstruct Navigate(MethodInfo method, object[] parameters)
        {
            if (_onlyProperyInitialization)
            {
                if (method.Name.StartsWith("set_"))
                {
                    var name = method.Name.Replace("set_", "");
                    if (Scope.Generator.CurrentScope is IInstanceInitializerScope iScope)
                    {
                        if (Scope.Generator.CurrentScope.Codes.Any(code => code is IInstanceInitializerScope scope && scope.PropertyAssignedName == name))
                            return new Nop(Scope);
                    }
                    return new PropertyInitializer(Scope.Generator.CurrentScope, this, method, parameters);
                }
                throw new InvalidOperationException("Only property set operation allowed in this scope.");
            }
            else
            {
                return base.Navigate(method, parameters);
            }
        }

        public void OnDefinitionAssignedTo(MethodInfo method)
        {
            PropertyAssignedName = method.Name.Replace("set_", "");
        }
    }
}
