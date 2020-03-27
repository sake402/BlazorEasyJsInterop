using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace LivingThing.TCCS.Interface
{
    public interface IScopeParameterBag<TParameter>
    {
        T Get<T>(Expression<Func<TParameter, T>> get);
    }
}
