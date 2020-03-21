using LivingThing.TCCS.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingThing.TCCS.Core
{
    public class ParameterBag
    {
        public ParameterBag(Dictionary<string, object> parameters)
        {
            Parameters = parameters;
        }

        bool _disabled;
        public ParameterBag(bool disabled = false)
        {
            _disabled = disabled;
        }

        public Dictionary<string, object> Parameters { get; } = new Dictionary<string, object>();
        public string Set(IParameterized setter, int index, object value)
        {
            if (_disabled)
            {
                if (value is string str)
                {
                    return "\"" + str.Replace("\"", "\\\"") + "\"";
                }
                if (value is bool b)
                {
                    return b ? "true" : "false";
                }
                return value?.ToString() ?? "null";
            }
            var key = setter.ParameterName + (index >= 0 ? "_" + index : "");
            Parameters[key] = value;
            return $"p.{key}";
        }

        public string SetMany(IParameterized setter, params object[] parameters)
        {
            if (_disabled)
            {
                return "[" + string.Join(", ", parameters.Select(parameter =>
                {
                    if (parameter is string str)
                    {
                        return "\"" + str.Replace("\"", "\\\"") + "\"";
                    }
                    if (parameter is bool b)
                    {
                        return b ? "true" : "false";
                    }
                    return parameter?.ToString() ?? "null";
                })) + "]";
            }
            var key = setter.ParameterName;
            Parameters[key] = parameters;
            return $"p.{key}";
        }

        public void SetFor<TDefinition>(TDefinition definition, params object[] parameters) where TDefinition : class
        {
            //CodeDefinition def = definition as CodeDefinition;
            for (int i = 0; i < parameters.Length; i++)
            {
                //Set(def.Interceptor.Target, i, parameters[i]);
            }
        }

        public ParameterBag Clone()
        {
            var newDic = new Dictionary<string, object>(Parameters);
            return new ParameterBag(newDic);
        }
    }
}
