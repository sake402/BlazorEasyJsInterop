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

        protected object[] GetParameters()
        {
            return Parameters.Select((p, i) =>
            {
                var pp = p.UnWrap();
                if (pp != null && Scope.Generator.Definitions.ContainsKey(pp))
                {
                    var ic = Scope.Generator.Definitions[pp];
                    var target = ic.Interceptor.Target;
                    if (target is ICodeResult result)
                        return result.VariableName;
                }
                return Scope.ParameterBag.Set(this, Parameters.Length > 1 ? i : -1, pp);
            }).ToArray();
        }

        public virtual ICodeConstruct Navigate(MethodInfo method, object[] parameters)
        {
            return this.TryNavigate(method, parameters);
        }
    }
}
