using LivingThing.TCCS.Attributes;
using LivingThing.TCCS.Interface;
using LivingThing.TCCS.Scopes;
using LivingThing.TCCS.Util;
using System;
using System.Linq;
using System.Reflection;

namespace LivingThing.TCCS.Lexicon
{
    internal class MethodCall: CodeConstruct, IParameterized, ICodeResult
    {
        public MethodCall(GeneratorScope generatorScope, CodeConstruct parent, MethodInfo method, object[] paramaters):base(generatorScope, parent, paramaters)
        {
            Method = method;
        }

        //public Method(GeneratorScope generatorScope, string code, object[] paramaters) : base(generatorScope, null)
        //{
        //    _code = code;
        //    _parameters = paramaters;
        //    generatorScope.Codes.Add(this);
        //}

        protected MethodInfo Method { get; }

        public override Type[] ParameterTypes => Method.GetParameters().Select(m => m.ParameterType).ToArray();

        protected int Depth => ((From as MethodCall)?.Depth ?? -1) + 1;

        protected string JavascriptCode
        {
            get
            {
                var nameAttr = Method?.GetCustomAttribute<NameAttribute>();
                string methodName = nameAttr?.Name ?? Scope.Generator.Options?.MethodNameFormatter?.Invoke(Method) ?? Method.Name;
                var parameters = GetParameters();
                var code = $"{methodName}({string.Join(", ", parameters)})";
                if (From != null)
                {
                    if (From.HasVariableName)
                        code = $"{From.VariableName}.{code}";
                    else
                        code = $"{From}.{code}";
                }
                if (HasVariableName)
                {
                    return $"{VariableDeclaration} = {code}";
                }
                else
                {
                    return $"{code}";
                }
            }
        }

        //public override string ParameterName => VariableName;

        //MethodCall GetMethod(MethodInfo method, object[] paramaters = null)
        //{
        //    return new MethodCall(Scope.Generator.CurrentScope, this, method, paramaters);
        //}

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

        //public override ICodeConstruct Navigate(MethodInfo method, object[] paramaters = null)
        //{
        //    variableName ??= Utility.GenerateVariableName();
        //    return GetMethod(method, paramaters);
        //}
    }

}
