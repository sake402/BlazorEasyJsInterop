using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace LivingThing.TCCS.Interface
{
    public interface ICodeConstruct:ICode
    {
        ICodeConstruct From { get; }
        ICodeConstruct Navigate(MethodInfo method, object[] paramaters);
    }
}
