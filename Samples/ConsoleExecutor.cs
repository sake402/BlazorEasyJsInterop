using LivingThing.TCCS.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LivingThing.TCCS.Samples
{
    public class ConsoleExecutor : IScriptExecutor
    {
        public Task<T> ExecuteAsync<T>(string javascript, params object[] parameters)
        {
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine(javascript);
            foreach (var p in parameters)
            {
                var dic = p as Dictionary<string, object>;
                if (dic != null)
                {
                    foreach (var kv in dic)
                    {
                        System.Console.WriteLine($"{kv.Key}({kv.Value?.GetType().Name ?? "null"}) : {kv.Value}");
                    }
                }
                System.Console.WriteLine($"{p}");
            }
            return Task.FromResult(default(T));
        }
    }
}
