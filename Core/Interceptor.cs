using System;
using System.Threading.Tasks;
using System.Reflection;
using System.Dynamic;
using Castle.DynamicProxy;
using LivingThing.TCCS.Util;
using LivingThing.TCCS.Interface;
using LivingThing.TCCS.Scopes;
using LivingThing.TCCS.Lexicon;
using System.Collections.Generic;
using System.Linq;

namespace LivingThing.TCCS.Core
{
    internal class Interceptor<TDefinition> : DynamicObject, IScriptInterceptor, IInterceptor where TDefinition: class
    {
        static ProxyGenerator generator = new ProxyGenerator();

        public Interceptor(GeneratorScope scope, ICodeConstruct target)
        {
            Scope = scope;
            Target = target;
        }

        public GeneratorScope Scope { get; }
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
            List<object> arguments = new List<object>();
            foreach (var param in invocation.Arguments)
            {
                var vparam = param.UnWrap();
                if (vparam != null)
                {
                    var context = Scope.Generator.GetDefinition(vparam);
                    //if (invocation.Method.Name.StartsWith("set_"))
                    //{
                    //    if (context?.Watcher != null)
                    //    {
                    //        context.Watcher.OnDefinitionAssignedTo(invocation.Method);
                    //    }
                    //}
                    if (context != null && context.Interceptor.Target is CodeConstruct construct)
                    {
                        construct.OnAssignedTo(invocation.Method);
                    }
                }
                if (param != null)
                {
                    if (param is Action action)
                    {
                        var fd = new FunctionDelegate(Scope, param);
                        arguments.Add(fd);
                    }
                    else
                    {
                        arguments.Add(param);
                    }
                }
                else
                {
                    arguments.Add(param);
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
                newCodeConstruct = Target.Navigate(invocation.Method, arguments.ToArray());
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
            
            if (!invocation.Method.ReturnType.IsPrimitive && !invocation.Method.ReturnType.IsSealed && invocation.Method.ReturnType.FullName != "System.Void")
            {
                var type = typeof(Interceptor<>).MakeGenericType(invocation.Method.ReturnType);
                var interceptor = Activator.CreateInstance(type, Scope, newCodeConstruct);
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

        public TDefinition GetProxyAsync(object[] parameters)
        {
            if (typeof(TDefinition).IsInterface)
            {
                var r = generator.CreateInterfaceProxyWithoutTarget<TDefinition>(new ProxyGenerationOptions()
                {
                }, this);
                Scope.Generator.AddDefinition(Scope, this, r);
                return r;
            }
            else
            {
                var r = generator.CreateClassProxy<TDefinition>(new ProxyGenerationOptions()
                {
                }, this);
                Scope.Generator.AddDefinition(Scope, this, r);
                return r;
            }
        }

        internal void ActionCallTarget0()
        {
            new DelegateCall(Scope, Target as CodeConstruct, new object[] { });
        }

        internal void ActionCallTarget1<T>(T parameter)
        {
            new DelegateCall(Scope, Target as CodeConstruct, new object[] { parameter });
        }

        internal void ActionCallTarget2<T1, T2>(T1 parameter1, T2 parameter2)
        {
            new DelegateCall(Scope, Target as CodeConstruct, new object[] { parameter1, parameter2 });
        }

        internal void ActionCallTarget3<T1, T2, T3>(T1 parameter1, T2 parameter2, T3 parameter3)
        {
            new DelegateCall(Scope, Target as CodeConstruct, new object[] { parameter1, parameter2, parameter3 });
        }

        internal void ActionCallTarget4<T1, T2, T3, T4>(T1 parameter1, T2 parameter2, T3 parameter3, T4 parameter4)
        {
            new DelegateCall(Scope, Target as CodeConstruct, new object[] { parameter1, parameter2, parameter3, parameter4 });
        }

        internal void ActionCallTarget5<T1, T2, T3, T4, T5>(T1 parameter1, T2 parameter2, T3 parameter3, T4 parameter4, T5 parameter5)
        {
            new DelegateCall(Scope, Target as CodeConstruct, new object[] { parameter1, parameter2, parameter3, parameter4, parameter5 });
        }

        internal T FuncCallTarget1<T>() where T:class
        {
            var newConstruct= new DelegateCall(Scope, Target as CodeConstruct, new object[] { });
            return new Interceptor<T>(Scope, newConstruct).GetProxy(null);
        }

        internal T FuncCallTarget2<T, T1>(T1 parameter) where T : class
        {
            var newConstruct = new DelegateCall(Scope, Target as CodeConstruct, new object[] { parameter });
            return new Interceptor<T>(Scope, newConstruct).GetProxy(null);
        }

        internal T FuncCallTarget3<T, T1, T2>(T1 parameter1, T2 parameter2) where T : class
        {
            var newConstruct = new DelegateCall(Scope, Target as CodeConstruct, new object[] { parameter1, parameter2 });
            return new Interceptor<T>(Scope, newConstruct).GetProxy(null);
        }

        internal T FuncCallTarget4<T, T1, T2, T3>(T1 parameter1, T2 parameter2, T3 parameter3) where T : class
        {
            var newConstruct = new DelegateCall(Scope, Target as CodeConstruct, new object[] { parameter1, parameter2, parameter3 });
            return new Interceptor<T>(Scope, newConstruct).GetProxy(null);
        }

        internal T FuncCallTarget5<T, T1, T2, T3, T4>(T1 parameter1, T2 parameter2, T3 parameter3, T4 parameter4) where T : class
        {
            var newConstruct = new DelegateCall(Scope, Target as CodeConstruct, new object[] { parameter1, parameter2, parameter3, parameter4 });
            return new Interceptor<T>(Scope, newConstruct).GetProxy(null);
        }

        internal TDefinition GetProxy(/*IWatchDefinition watcher*/ object a)
        {
            //return this.ActLike<TDefinition>();
            if (typeof(TDefinition).IsInterface)
            {
                var r = generator.CreateInterfaceProxyWithoutTarget<TDefinition>(new ProxyGenerationOptions()
                {
                }, this);
                var def = Scope.Generator.AddDefinition(Scope, this, r);
                //def.Watcher = watcher;
                return r;
            }
            else if (typeof(TDefinition).FullName.StartsWith("System.Func") || typeof(TDefinition).FullName.StartsWith("System.Action"))
            {
                var type = typeof(TDefinition);
                Type[] genericTypes = type.IsGenericType ? type.GetGenericArguments() : new Type[0];
                Type returns = null;
                bool isFunc = type.FullName.StartsWith("System.Func");
                if (isFunc) {
                    returns = genericTypes.Last();
                    //genericTypes = genericTypes.Except(new Type[] { returns }).ToArray();
                }
                object r = null;
                if (!isFunc)
                {
                    var method = GetType().GetMethod(nameof(ActionCallTarget0).Replace("0", "")+ genericTypes.Length, BindingFlags.Instance | BindingFlags.NonPublic).MakeGenericMethod(genericTypes);
                    r = Delegate.CreateDelegate(type, this, method);
                }
                else
                {
                    var method = GetType().GetMethod(nameof(FuncCallTarget1).Replace("1", "")+ genericTypes.Length, BindingFlags.Instance | BindingFlags.NonPublic).MakeGenericMethod(genericTypes);
                    r = Delegate.CreateDelegate(type, this, method);
                }
                var def = Scope.Generator.AddDefinition(Scope, this, r);
                //def.Watcher = watcher;
                return r as TDefinition;
            }
            else
            {
                var r = generator.CreateClassProxy<TDefinition>(new ProxyGenerationOptions()
                {
                }, this);
                var def = Scope.Generator.AddDefinition(Scope, this, r);
                //def.Watcher = watcher;
                return r;
            }
        }

    }
}
