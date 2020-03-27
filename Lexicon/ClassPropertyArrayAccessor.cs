using LivingThing.TCCS.Core;
using LivingThing.TCCS.Interface;
using LivingThing.TCCS.Scopes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingThing.TCCS.Lexicon
{
    internal class ClassPropertyArrayAccessor<TDefinition> : ClassPropertyAccessor<TDefinition[]>, IClassPropertyArrayAccessor<TDefinition> where TDefinition:class
    {
        public ClassPropertyArrayAccessor(string propertyName, GeneratorScope scope, params object[] parameters) : base(propertyName, null, scope, parameters)
        {

        }

        public override string ToString()
        {
            if (Parameters != null)
            {
                var ps = string.Join(", ", Parameters.Select(m => m.ToString()));
                return $"{Name}:[{ps}]";
            }
            else
            {
                return $"{Name}:[]";
            }
        }
    }
}
