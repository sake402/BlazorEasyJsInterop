using Castle.DynamicProxy;
using LivingThing.TCCS.Interface;
using LivingThing.TCCS.Scopes;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace LivingThing.TCCS.Core
{
    internal class ScopeParameterBag<TParameter> : IScopeParameterBag<TParameter> where TParameter:class
    {
        GeneratorScope Scope;
        internal ScopeParameterBag(GeneratorScope scope) 
        {
            Scope = scope;
        }

        public T Get<T>(Expression<Func<TParameter, T>> get)
        {
            var name = get.ToString();
            int dot = name.IndexOf(".");
            name = name.Substring(dot + 1).Trim();
            T initialValue = default;
            if (typeof(T) == typeof(double))
            {
                Random r = new Random();
                initialValue = (T)(object)r.NextDouble();
            }
            else if (typeof(T) == typeof(string))
            {
                Random r = new Random();
                byte[] k = new byte[6];
                r.NextBytes(k);
                initialValue = (T)(object)Convert.ToBase64String(k);
            }
            else if (typeof(T).IsArray)
            {
                initialValue = (T)Activator.CreateInstance(typeof(T), new object[] { 0 });
            }
            else if (!typeof(T).IsPrimitive && !typeof(T).IsAbstract && !typeof(T).IsInterface && typeof(T).GetConstructor(new Type[] { }) != null)
            {
                initialValue = (T)Activator.CreateInstance(typeof(T), new object[] { });
            }
            return Scope.ParameterBag.NamedParameter<T>(name, initialValue);
        }
    }
}
