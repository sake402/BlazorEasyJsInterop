using System;
using System.Collections.Generic;
using System.Text;

namespace LivingThing.TCCS.Interface
{
    public interface IClassPropertyAccessor<TDefinition> where TDefinition : class
    {
        void Set(TDefinition defintion);
        TDefinition Get();
    }
}
