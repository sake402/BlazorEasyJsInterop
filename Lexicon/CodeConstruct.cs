using System;
using System.Linq;
using System.Reflection;
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
        public virtual Type[] ParameterTypes => Parameters.Select(p => p?.GetType()).ToArray();
        protected string variableName;
        public bool HasVariableName => !string.IsNullOrEmpty(variableName);
        public string VariableName
        {
            get => variableName ??= Utility.GenerateVariableName();
            set { variableName = value; }
        }
        protected string parameterName;
        public virtual string ParameterNamePrefix => parameterName ??= Utility.GenerateVariableName();

        protected string VariableDeclaration => VariableName.StartsWith("x.") || VariableName.StartsWith("(") ? VariableName : "var " + VariableName;

        protected CodeConstruct(GeneratorScope scope, CodeConstruct from, object[] parameters)
        {
            Scope = scope;
            From = from;
            Parameters = parameters;
            if (scope != null)
                scope.Codes.Add(this);
        }


        IGeneratorScope ICode.Scope => Scope;

        ICodeConstruct ICodeConstruct.From => From;

        //object Resolve(object parameter, int index)
        //{
        //    if (parameter != null)
        //    {
        //        var definition = Scope.Generator.GetDefinition(parameter);
        //        if (definition != null)
        //        {
        //            var target = definition.Interceptor.Target;
        //            if (target is ICodeResult result)
        //                return result.VariableName;
        //        }
        //    }
        //    if (parameter is ICodeResult mresult)
        //        return mresult.VariableName;
        //    return Scope.ParameterBag.Set(this, Parameters.Length > 1 ? index : -1, parameter);
        //}

        protected object[] GetParameters()
        {
            return Parameters.Select((p, i) =>
            {
                var parameter = p.UnWrap(Scope, this, i);
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
            variableName ??= Utility.GenerateVariableName();
            return this.TryNavigate(method, parameters);
        }

        public virtual void OnAssignedTo(MethodInfo method)
        {
            //if (!(Scope is IInstanceInitializerScope iScope) && !iScope.IsPropertyInitialization)
            {
                variableName ??= Utility.GenerateVariableName();
            }
        }
    }
}
