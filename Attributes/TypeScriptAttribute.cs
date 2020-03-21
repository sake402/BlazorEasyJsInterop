using System;
using System.Collections.Generic;
using System.Text;

namespace LivingThing.TCCS.Attributes
{
    public class TypeScriptAttribute:Attribute
    {
        public string DefinitionInitCode { get; set; }
        public bool Static { get; set; }
    }
}
