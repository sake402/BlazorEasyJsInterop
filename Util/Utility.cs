using System;
using System.Collections;
using System.Collections.Generic;
using LivingThing.TCCS.Definitions.Util;
using LivingThing.TCCS.Interface;
using LivingThing.TCCS.Scopes;

namespace LivingThing.TCCS.Util
{
    internal static class Utility
    {
        public static object DoUnWrap(this object parameter, GeneratorScope scope, IParameterized parameterized, int i, ref bool dontBag)
        {
            if (parameter != null)
            {
                if (parameter is Union union)
                {
                    return DoUnWrap(union.Value, scope, parameterized, i, ref dontBag);
                }
                if (parameter is TypeAlias alias)
                {
                    return DoUnWrap(alias.Value, scope, parameterized, i, ref dontBag);
                }
                if (parameter is Enumerated enume)
                {
                    return DoUnWrap(enume.Value, scope, parameterized, i, ref dontBag);
                }
                var type = parameter.GetType();
                if (type.IsArray && parameter is IEnumerable array)
                {
                    var enumerator = array.GetEnumerator();
                    bool hasContent = enumerator.MoveNext();
                    if (hasContent)
                    {
                        object first = enumerator.Current;
                        var firstType = first?.GetType();
                        if (firstType != null && (firstType != typeof(string)))
                        {
                            List<object> items = new List<object>();
                            foreach (var item in array)
                            {
                                bool noBag = false;
                                items.Add(DoUnWrap(item, scope, parameterized, i, ref noBag));
                            }
                            parameter = items.ToArray();
                        }
                    }
                }
                //if (scope != null && type.Name.EndsWith("Proxy"))
                //{
                //    parameter = scope.Generator.Definitions[parameter].Interceptor.Target;
                //}
                if (scope != null)
                {
                    var definition = scope.Generator.GetDefinition(parameter);
                    if (definition != null)
                    {
                        parameter = definition.Interceptor.Target;
                    }
                }
                if (parameter is ICodeResult mresult)
                {
                    dontBag = true;
                    return mresult.VariableName;
                }
                //if (parameter is ICode code)
                //    return UnWrap(code);
                if (dontBag == false && scope != null)
                {
                    //dontBag = true;
                    //parameter = scope.ParameterBag.Set(parameterized, i, parameter);
                }
            }
            return parameter;
        }

        public static object UnWrap(this object parameter, GeneratorScope scope = null, IParameterized parameterized = null, int i = -1)
        {
            bool dontBag = false;
            var unwraped =  DoUnWrap(parameter, scope, parameterized, i, ref dontBag);
            return scope?.ParameterBag.Set(parameterized, i, unwraped) ?? unwraped;
            return unwraped;
        }

        public static string GenerateVariableName()
        {
            string allowedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random random = new Random();
            char[] c = new char[3];
            for (int i = 0; i < c.Length; i++)
            {
                var cc = random.Next() % allowedChars.Length;
                c[i] = allowedChars[cc];
            }
            return "$" + new string(c);
        }
    }
}
