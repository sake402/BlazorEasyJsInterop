using System;
using System.Collections.Generic;
using System.Text;

namespace LivingThing.TCCS.Attributes
{
    public class NameAttribute:Attribute
    {
        public NameAttribute(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
