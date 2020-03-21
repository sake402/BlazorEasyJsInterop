using LivingThing.TCCS.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivingThing.TCCS.Core
{
    internal class DefinitionContext
    {
        public IScriptInterceptor Interceptor { get; set; }
        public IWatchDefinition Watcher { get; set; }
    }
}
