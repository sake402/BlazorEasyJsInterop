using LivingThing.TCCS.Core;
using LivingThing.TCCS.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace LivingThing.TCCS.Scopes
{
    internal class InstanceInitializerScope : GeneratorScope, IWatchDefinition
    {
        public InstanceInitializerScope(Generator generator, Type instanceType, string instanceName, GeneratorScope parentScope, bool onlyProperyInitialization) 
            : base(generator, false, parentScope)
        {
            InstanceType = instanceType;
            InstanceName = instanceName;
            _onlyProperyInitialization = onlyProperyInitialization;
        }


        Type InstanceType { get; }
        string InstanceName { get; }
        bool _onlyProperyInitialization;

        public override string ToString()
        {
            if (_onlyProperyInitialization)
            {
                if (ParentScope is InstanceInitializerScope)
                {
                    return $"{PropertyAssignedName} : {{ { string.Join(", ", Codes.Select(t => t.ToString()).Where(c=> !string.IsNullOrEmpty(c))) } }}";
                }
                else
                {
                    return $"var {InstanceName} = {{ { string.Join(", ", Codes.Select(t => t.ToString()).Where(c => !string.IsNullOrEmpty(c))) } }}";
                }
            }
            else
                return $"var {InstanceName} = (function(){{\r\n{base.ToString()};\r\nreturn {InstanceName};\r\n}})()";
        }

        public string PropertyAssignedName { get; set; }
        public void OnDefinitionAssignedTo(MethodInfo method)
        {
            PropertyAssignedName = method.Name.Replace("set_", "");
        }
    }
}
