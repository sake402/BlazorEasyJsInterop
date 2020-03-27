using System;
using System.Collections.Generic;
using System.Text;

namespace LivingThing.TCCS.Definitions.Util
{
    public abstract class Enumerated
    {
       public object Value { get; set; }
    }

    public abstract class Enumerated<T> : Enumerated
    {

    }
}
