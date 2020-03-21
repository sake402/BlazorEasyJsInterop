using System;
using System.Collections.Generic;
using System.Text;
using LivingThing;
using LivingThing.TCCS.Definitions.Util;

namespace LivingThing.TCCS.Util
{
    internal static class Utility
    {
        public static object UnWrap(this object parameter)
        {
            if (parameter is Union union)
            {
                return UnWrap(union.Value);
            }
            if (parameter is TypeAlias alias)
            {
                return UnWrap(alias.Value);
            }
            if (parameter is Enumerated enume)
            {
                return UnWrap(enume.Value);
            }
            return parameter;
        }

        public static string GenerateVariableName()
        {
            string allowedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random random = new Random();
            char[] c = new char[3];
            for (int i = 0; i < c.Length; i++)
            {
                var cc = random.Next() % allowedChars.Length;
                c[i] = allowedChars[cc];
            }
            return new string(c);
        }
    }
}
