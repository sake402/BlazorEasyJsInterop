using System;
using System.Threading.Tasks;
using System.Reflection;
using System.Dynamic;
using Castle.DynamicProxy;
using LivingThing.TCCS.Util;
using LivingThing.TCCS.Interface;

namespace LivingThing.TCCS.Core
{
    internal class Interceptor<TDefinition> : DynamicObject, IScriptInterceptor, IInterceptor where TDefinition: class
    {
        public Interceptor(Generator generator, ICodeConstruct target)
        {
            Generator = generator;
            Target = target;
        }

        public Generator Generator { get; }
        public ICodeConstruct Target { get; }
        public override string ToString()
        {
            return Target.ToString();
        }

        //void InvokeMemeber(string name, Type returnType, object[] args, out object result)
        //{
        //    if (returnType != null && returnType.IsInterface)
        //    {
        //        var newMethod = Method.GetMethod(name, args);
        //        var type = typeof(TypeScriptInterceptor<>).MakeGenericType(returnType);
        //        var interceptor = Activator.CreateInstance(type, Generator, newMethod);
        //        var getProxyMethod = type.GetMethod(nameof(TypeScriptInterceptor<TDefinition>.GetProxy), BindingFlags.NonPublic | BindingFlags.Instance);
        //        result = getProxyMethod.Invoke(interceptor, new object[] { });
        //        //invocation.ReturnValue = new TypeScriptInterceptor(JavaScript, newMethod).GetProxy();//.ExecuteMethodSync();
        //    }
        //    else
        //    {
        //        if (returnType != null && typeof(Task).IsAssignableFrom(returnType))
        //            result = Method.Execute<object>(Generator.JavaScript);
        //        else
        //            result = Method.Execute<object>(Generator.JavaScript).Result;
        //    }
        //}

        //public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
        //{
        //    InvokeMemeber(binder.Name, binder.ReturnType, args, out result);
        //    return true;
        //}

        //object propertyValue;
        public virtual void Intercept(IInvocation invocation)
        {
            if (invocation.Method.Name.StartsWith("set_"))
            {
                foreach (var param in invocation.Arguments)
                {
                    var vparam = param.UnWrap();
                    if (vparam != null && Generator.Definitions.ContainsKey(vparam))
                    {
                        var context = Generator.Definitions[vparam];
                        if (context.Watcher != null)
                        {
                            context.Watcher.OnDefinitionAssignedTo(invocation.Method);
                        }
                    }
                }
            }
            //object result;
            //InvokeMemeber(invocation.Method.Name, invocation.Method.ReturnType, invocation.Arguments, out result);
            //invocation.ReturnValue = result;
            //if (invocation.Method.ReturnType != null && !invocation.Method.ReturnType.IsPrimitive)
            //{
            ICodeConstruct newCodeConstruct = null;
            //try
            //{
                newCodeConstruct = Target.Navigate(invocation.Method, invocation.Arguments);
            //}
            //catch (InvalidOperationException)
            //{
            //    if (invocation.Method.ReturnType.IsPrimitive && invocation.Method.Name.StartsWith("get_"))
            //    {
            //        invocation.ReturnValue = propertyValue;
            //    }
            //    else
            //        throw;
            //}
            
            if (!invocation.Method.ReturnType.IsPrimitive && invocation.Method.ReturnType.FullName != "System.Void")
            {
                var type = typeof(Interceptor<>).MakeGenericType(invocation.Method.ReturnType);
                var interceptor = Activator.CreateInstance(type, Generator, newCodeConstruct);
                var getProxyMethod = type.GetMethod(nameof(Interceptor<TDefinition>.GetProxy), BindingFlags.NonPublic | BindingFlags.Instance);
                invocation.ReturnValue = getProxyMethod.Invoke(interceptor, new object[] { null });
            }
            //else if (invocation.Method.ReturnType.IsPrimitive && invocation.Method.Name.StartsWith("set_"))
            //{
            //    propertyValue = invocation.Arguments[0];
            //}
            //else if (invocation.Method.ReturnType.IsPrimitive && invocation.Method.Name.StartsWith("get_"))
            //{
            //    invocation.ReturnValue = propertyValue;
            //}
            //invocation.ReturnValue = new TypeScriptInterceptor(JavaScript, newMethod).GetProxy();//.ExecuteMethodSync();
            //}
            //else
            //{
            //if (invocation.Method.ReturnType != null && typeof(Task).IsAssignableFrom(invocation.Method.ReturnType))
            //    invocation.ReturnValue = Method.Execute<object>(Generator.JavaScript);
            //else
            //    invocation.ReturnValue = Method.Execute<object>(Generator.JavaScript).Result;
            //}

            //TypeScriptMethod executor;
            //if (Method != null)
            //{
            //    executor = Method.GetMethod(invocation.Method, invocation.Arguments);
            //}
            //else
            //{
            //    executor = new TypeScriptMethod<TDefinition>(this, invocation.Method, invocation.Arguments);
            //}
            //Returns = executor;
            //if (invocation.Method.ReturnType == null)
            //    executor.ExecuteVoidMethod();
            //else if (typeof(Task).IsAssignableFrom(invocation.Method.ReturnType))
            //    invocation.ReturnValue = executor.ExecuteMethodAsync();
            //else
            //    invocation.ReturnValue = executor.ExecuteMethodSync();
        }

        //TypeScriptAttribute Attribute { get; set; }

        public async Task<TDefinition> GetProxyAsync(object[] parameters)
        {
            //await JavaScript.Queue(j =>
            //{
            //    Attribute = typeof(TDefinition).GetCustomAttribute<TypeScriptAttribute>();
            //    string initCode = Attribute.DefinitionInitCode;
            //    if (!Attribute.Static)
            //    {
            //        j.InvokeVoidAsync($"window[\"{typeof(TDefinition).Name}\"]={{ {initCode} }};", parameters);
            //    }
            //    else
            //    {
            //        j.InvokeVoidAsync($"{initCode};", parameters);
            //    }
            //});
            ProxyGenerator generator = new ProxyGenerator();
            if (typeof(TDefinition).IsInterface)
            {
                var r = generator.CreateInterfaceProxyWithoutTarget<TDefinition>(new ProxyGenerationOptions()
                {
                }, this);
                Generator.Definitions[r] = new DefinitionContext() { Interceptor = this };
                return r;
            }
            else
            {
                var r = generator.CreateClassProxy<TDefinition>(new ProxyGenerationOptions()
                {
                }, this);
                Generator.Definitions[r] = new DefinitionContext() { Interceptor = this };
                return r;
            }
        }

        internal TDefinition GetProxy(IWatchDefinition watcher)
        {
            //return this.ActLike<TDefinition>();
            ProxyGenerator generator = new ProxyGenerator();
            if (typeof(TDefinition).IsInterface)
            {
                var r = generator.CreateInterfaceProxyWithoutTarget<TDefinition>(new ProxyGenerationOptions()
                {
                }, this);
                Generator.Definitions[r] = new DefinitionContext() { Interceptor = this, Watcher = watcher };
                return r;
            }
            else
            {
                var r = generator.CreateClassProxy<TDefinition>(new ProxyGenerationOptions()
                {
                }, this);
                Generator.Definitions[r] = new DefinitionContext() { Interceptor = this, Watcher = watcher };
                return r;
            }
        }

    }
}
