using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using LivingThing.TCCS.Interface;
using LivingThing.TCCS.Scopes;
using LivingThing.TCCS.Util;

namespace LivingThing.TCCS.Lexicon
{
    internal abstract class CodeConstruct:ICodeConstruct, IParameterized
    {
        public GeneratorScope Scope { get; }
        public CodeConstruct From { get; }
        public object[] Parameters { get; }
        protected string variableName;
        public string VariableName => variableName ??= Util.Utility.GenerateVariableName();
        protected string parameterName;
        public string ParameterName => parameterName ??= Util.Utility.GenerateVariableName();

        protected CodeConstruct(GeneratorScope scope, CodeConstruct from, object[] parameters)
        {
            Scope = scope;
            From = from;
            Parameters = parameters;
            scope.Codes.Add(this);
        }


        IGeneratorScope ICode.Scope => Scope;

        ICodeConstruct ICodeConstruct.From => From;

        object Resolve(object parameter, int index)
        {
            if (parameter != null && Scope.Generator.Definitions.ContainsKey(parameter))
            {
                var ic = Scope.Generator.Definitions[parameter];
                var target = ic.Interceptor.Target;
                if (target is ICodeResult result)
                    return result.VariableName;
            }
            if (parameter is ICodeResult mresult)
                return mresult.VariableName;
            return Scope.ParameterBag.Set(this, Parameters.Length > 1 ? index : -1, parameter);
        }

        protected object[] GetParameters()
        {
            return Parameters.Select((p, i) =>
            {
                var parameter = p.UnWrap(Scope, this, Parameters.Length > 1 ? i : -1);
                //if (parameter is IEnumerable array && !(parameter is string))
                //{
                //    string sparam = "[ ";
                //    foreach (var item in array)
                //    {
                //        sparam += item.ToString();
                //        sparam += ", ";
                //    }
                //    sparam = sparam.Trim(',', ' ');
                //    sparam += " ]";
                //    return sparam;
                //}
                return parameter;
                //if (type.Name.EndsWith("Proxy"))
                //{
                //    var target = scope.Generator.Definitions[parameter].Interceptor.Target;
                //    if (target is ICodeResult codeResult)
                //        return codeResult.VariableName;
                //    return null;// UnWrap(generator.Definitions[parameter].Interceptor.Target, generator);
                //}
                //if (paramemeter != null)
                //{
                //    var type = paramemeter.GetType();
                //    if (type.IsArray)
                //    {
                //        var array = paramemeter as IEnumerable;
                //        var enumerator = array.GetEnumerator();
                //        enumerator.MoveNext();
                //        object first = enumerator.Current;
                //        var firstType = first?.GetType();
                //        if (firstType != null && typeof(ICode).IsAssignableFrom(firstType))
                //        {
                //            List<object> items = new List<object>();
                //            foreach (var item in array)
                //            {
                //                items.Add(Resolve(item, i + Parameters.Length));
                //            }
                //            return items.ToArray();
                //        }
                //    }
                //}
                //return Resolve(paramemeter, i);
            }).ToArray();
        }

        public virtual ICodeConstruct Navigate(MethodInfo method, object[] parameters)
        {
            return this.TryNavigate(method, parameters);
        }
    }
}
