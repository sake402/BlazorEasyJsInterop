using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LivingThing.TCCS.Interface
{
    public interface IScriptExecutor
    {
        Task<T> ExecuteAsync<T>(string javascript, params object[] parameters);
    }
}
