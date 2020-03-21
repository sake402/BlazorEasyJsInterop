using LivingThing.TCCS.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivingThing.TCCS.Scopes
{
    internal class ForLoopScope: GeneratorScope, IParameterized, ICode
    {
        string parameterKey;

        public ForLoopScope(string name, object start, object step, object limit, GeneratorScope scope):base(scope.Generator, false, scope)
        {
            ParameterName = name;
            parameterKey = ParameterBag.SetMany(this, start, step, limit);
        }

        public string ParameterName { get; set; }

        public override string ToString()
        {
            var begin = $"for (var i = {parameterKey}[0]; i < {parameterKey}[2]; i += {parameterKey}[1]) {{\r\n";
            var end = "\r\n}";
            return begin + base.ToString() + end;
        }
    }
}
