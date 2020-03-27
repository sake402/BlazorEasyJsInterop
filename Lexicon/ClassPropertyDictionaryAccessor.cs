using LivingThing.TCCS.Core;
using LivingThing.TCCS.Interface;
using LivingThing.TCCS.Scopes;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace LivingThing.TCCS.Lexicon
{
    internal class ClassPropertyDictionaryAccessor<TDefinition> : CodeConstruct, IClassDictionaryPropertyAccessor<TDefinition> where TDefinition : class
    {
        public ClassPropertyDictionaryAccessor(string name, GeneratorScope scope) : base(scope, null, null)
        {
            Name = name;
        }

        public TDefinition this[string key]
        {
            get
            {
                var literal = new LiteralCode(Scope.Generator.CurrentScope, $"this.{Name}[{{0}}]", key);
                return new Interceptor<TDefinition>(Scope.Generator.CurrentScope, literal).GetProxy(null);
            }
            set
            {
                var definition = Scope.Generator.GetDefinition(value);
                CodeConstruct c = definition.Interceptor.Target as CodeConstruct;
                c.OnAssignedTo(GetType().GetMethod("set_Item", BindingFlags.Public | BindingFlags.Instance));
                Scope.Generator.CurrentScope.Literal<object>($"this.{Name}[{{0}}] = {{1}}", key, value);
            }
        }

        string Name { get; }

        public override string ToString()
        {
            return $"{Name} = {{ }}"; ;
        }
    }
}
