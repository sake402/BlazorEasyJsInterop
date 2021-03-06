﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LivingThing.TCCS.Interface
{
    public interface IParameterized
    {
        string ParameterNamePrefix { get; }
        object[] Parameters { get; }
        Type[] ParameterTypes { get; }
    }
}
