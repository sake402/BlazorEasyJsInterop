using LivingThing.TCCS.Core;
using LivingThing.TCCS.Interface;
using LivingThing.TCCS.Scopes;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivingThing.TCCS.Lexicon
{
    internal class ClassPropertyAccessor<TDefinition> : CodeConstruct, IClassPropertyAccessor<TDefinition> where TDefinition:class
    {
        public ClassPropertyAccessor(string propertyName, string initialValue, GeneratorScope scope, params object[] parameters) : base(scope, null, parameters)
        {
            Name = propertyName;
            InitialValue = initialValue;
        }

        protected string Name { get; }
        protected string InitialValue { get; }

        public TDefinition Get()
        {
            var getter = new LiteralCode(Scope.Generator.CurrentScope, $"this.{Name}");
            //var getter = new ClassPropertyGetter(Name, Scope.Generator.CurrentScope);
            return new Interceptor<TDefinition>(Scope.Generator.CurrentScope, getter).GetProxy(null);
        }

        public void Set(TDefinition definition)
        {
            var def = Scope.Generator.GetDefinition(definition);
            if (def != null)
            {
                if (def.Interceptor.Target is ICodeResult result)
                    Scope.Generator.CurrentScope.Literal<object>($"this.{Name} = {result.VariableName}");
            }
        }

        public override string ToString()
        {
            if (InitialValue != null)
            {
                return $"{Name}:{InitialValue}";
            }
            else
            {
                return $"{Name}";
            }
        }
    }
}
