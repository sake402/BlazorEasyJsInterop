using System;
using System.Collections.Generic;
using System.Text;

namespace LivingThing.TCCS.Definitions.Util
{
    public abstract class TypeAlias
    {
        public object Value { get; set; }
    }

    public abstract class TypeAlias<T> : TypeAlias
    {

    }
}
