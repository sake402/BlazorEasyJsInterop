using LivingThing.TCCS.Attributes;
using LivingThing.TCCS.Interface;
using LivingThing.TCCS.Scopes;
using System.Linq;
using System.Reflection;

namespace LivingThing.TCCS.Lexicon
{
    internal class Method: CodeConstruct, IParameterized, ICodeResult
    {
        public Method(GeneratorScope generatorScope, CodeConstruct parent, MethodInfo method, object[] paramaters):base(generatorScope, parent, paramaters)
        {
            InterfaceMethod = method;
        }

        //public Method(GeneratorScope generatorScope, string code, object[] paramaters) : base(generatorScope, null)
        //{
        //    _code = code;
        //    _parameters = paramaters;
        //    generatorScope.Codes.Add(this);
        //}

        protected MethodInfo InterfaceMethod { get; }

        protected int Depth => ((From as Method)?.Depth ?? -1) + 1;

        protected string JavascriptCode
        {
            get
            {
                var nameAttr = InterfaceMethod?.GetCustomAttribute<NameAttribute>();
                string methodName = nameAttr?.Name ?? Scope.Generator.Options?.MethodNameFormatter?.Invoke(InterfaceMethod) ?? InterfaceMethod.Name;
                var parameters = GetParameters();
                var code = $"{methodName}({string.Join(", ", parameters)})";
                if (InterfaceMethod.ReturnType == null && parameters.Count() == 1) //property setter
                {
                    code = $"{methodName} = {parameters[0]}";
                }
                if (From != null)
                {
                    if (From.VariableName != null)
                        code = $"{From.VariableName}.{code}";
                    else
                    code = $"{(From as Method).JavascriptCode}.{code}";
                }
                if (VariableName != null)
                {
                    return $"var {VariableName} = {code}";
                }
                else
                {
                    return $"{code}";
                }
            }
        }

        string IParameterized.ParameterName => VariableName;

        Method GetMethod(MethodInfo method, object[] paramaters = null)
        {
            return new Method(Scope.Generator.CurrentScope, this, method, paramaters);
        }

        //public void Execute(IJavaScriptRunner javaScript)
        //{
        //    javaScript.Queue(j =>
        //    {
        //        var r = j.InvokeVoidAsync($"window.lt.execute", new object[] { JavascriptCode, Parameters });
        //    });
        //}

        //public Task<TResult> Execute<TResult>(IJavaScriptRunner javaScript)
        //{
        //    return javaScript.Queue<TResult>(j =>
        //    {
        //        var r = j.InvokeAsync<TResult>($"window.lt.execute", new object[] { JavascriptCode, Parameters }).AsTask();
        //        return r;
        //    });
        //}

        //public virtual Task ExecuteMethodAsync()
        //{
        //    return Parent.ExecuteMethodAsync();
        //}

        //public virtual object ExecuteMethodSync()
        //{
        //    return Parent.ExecuteMethodSync();
        //}

        //public virtual void ExecuteVoidMethod()
        //{
        //    Parent.ExecuteVoidMethod();
        //}

        public override string ToString()
        {
            //if (variableName != null)
            //    return variableName;
            return JavascriptCode;
        }

        public override ICodeConstruct Navigate(MethodInfo method, object[] paramaters = null)
        {
            return GetMethod(method, paramaters);
        }
    }

}
