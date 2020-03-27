using LivingThing.TCCS.Core;
using LivingThing.TCCS.Interface;
using LivingThing.TCCS.Lexicon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivingThing.TCCS.Scopes
{
    internal class ClassGeneratorScope : GeneratorScope, IClassGeneratorScope //where TParameter : class
    {
        public ClassGeneratorScope(string name, Generator generator, GeneratorScope parentScope) : base(generator, false, parentScope)
        {
            Name = name;
        }

        string Name { get; }
        internal Task Store()
        {
            var code = ToString();
            return Generator.Executor.ExecuteAsync<object>("window.lt.storeProcedure", new object[] 
            {
                Generator.GetHashCode().ToString(),
                GetHashCode().ToString(),
                code,
                ParameterBag.Parameters
            });
        }

        public Task<IFunctionGeneratorScope<TParameter>> DefineConstructor<TParameter>(Func<IGeneratorScope, IScopeParameterBag<TParameter>, Task> functionBuilder) where TParameter : class
        {
            return DefineFunction<TParameter>("constructor", functionBuilder);
        }

        public async Task<IFunctionGeneratorScope<TParameter>> DefineFunction<TParameter>(string name, Func<IGeneratorScope, IScopeParameterBag<TParameter>, Task> functionBuilder) where TParameter : class
        {
            var scope = new FunctionGeneratorScope<TParameter>(name, Generator, this);
            Generator.Scopes.Push(scope);
            await functionBuilder(scope, new ScopeParameterBag<TParameter>(scope));
            Generator.Scopes.Pop();
            //_ = scope.Store();
            return scope;
        }

        public IClassPropertyAccessor<TDefinition> DefineProperty<TDefinition>(string name, string initialValue = null) where TDefinition:class
        {
            return new ClassPropertyAccessor<TDefinition>(name, initialValue, this);
        }

        public IClassPropertyArrayAccessor<TDefinition> DefineArrayProperty<TDefinition>(string name, params TDefinition[] initialMembers) where TDefinition : class
        {
            return new ClassPropertyArrayAccessor<TDefinition>(name, this, initialMembers.Select(o => (object)o).ToArray());
        }

        public IClassDictionaryPropertyAccessor<TDefinition> DefineDictionaryProperty<TDefinition>(string name) where TDefinition : class
        {
            return new ClassPropertyDictionaryAccessor<TDefinition>(name, this);
        }

        public override string ToString()
        {
            return $"class {Name}\r\n{{\r\n{base.ToString()}\r\n}}\r\nreturn new {Name}(p, x);";
        }
    }

    internal class ClassGeneratorScope<TConstructorParameter> : ClassGeneratorScope, IClassGeneratorScope<TConstructorParameter> where TConstructorParameter : class
    {
        public ClassGeneratorScope(string name, Generator generator, GeneratorScope parentScope) : base(name, generator, parentScope)
        {
        }

        public Task Execute(TConstructorParameter parameter = null, ParameterBag bag = null)
        {
            if (bag != null)
            {
                bag = bag.Clone(parameter);
            }
            else
            {
                bag = new ParameterBag(parameter);
            }
            return Generator.Executor.ExecuteAsync<object>("window.lt.createClass", new object[] {
                Generator.GetHashCode().ToString(),
                GetHashCode().ToString(),
                bag.Parameters,
            });
        }

        public Task<TReturn> Call<TParameter, TReturn>(IFunctionGeneratorScope<TParameter> scope, TParameter parameter = default(TParameter), ParameterBag bag = null) where TParameter:class
        {
            if (bag != null)
            {
                bag = bag.Clone(parameter);
            }
            else
            {
                bag = new ParameterBag(parameter);
            }
            return Generator.Executor.ExecuteAsync<TReturn>("window.lt.callMember", new object[] {
                Generator.GetHashCode().ToString(),
                GetHashCode().ToString(),
                scope.Name,
                bag.Parameters,
            });
        }
    }
}
