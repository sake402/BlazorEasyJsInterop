using System;
using System.Collections.Generic;
using System.Text;

namespace LivingThing.TCCS.Interface
{
    public interface IClassDictionaryPropertyAccessor<TDefinition>
    {
        TDefinition this[string key] { get;set; }
    }
}
