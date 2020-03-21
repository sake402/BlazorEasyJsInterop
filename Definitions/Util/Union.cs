using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivingThing.TCCS.Definitions.Util
{
    public abstract class Union
    {
        public virtual object Value { get; set; }
    }

    public class Union<T1, T2>:Union
    {
        public Union(T1 value)
        {
            Value = value;
        }
        public Union(T2 value)
        {
            Value = value;
        }
        public static implicit operator Union<T1, T2>(T1 value)
        {
            return new Union<T1, T2>(value);
        }
        public static implicit operator Union<T1, T2>(T2 value)
        {
            return new Union<T1, T2>(value);
        }
    }

    public class Union<T1, T2, T3> : Union
    {
        public Union(T1 value)
        {
            Value = value;
        }
        public Union(T2 value)
        {
            Value = value;
        }
        public Union(T3 value)
        {
            Value = value;
        }
        public static implicit operator Union<T1, T2, T3>(T1 value)
        {
            return new Union<T1, T2, T3>(value);
        }
        public static implicit operator Union<T1, T2, T3>(T2 value)
        {
            return new Union<T1, T2, T3>(value);
        }
        public static implicit operator Union<T1, T2, T3>(T3 value)
        {
            return new Union<T1, T2, T3>(value);
        }
    }

    public class Union<T1, T2, T3, T4> : Union
    {
        public Union(T1 value)
        {
            Value = value;
        }
        public Union(T2 value)
        {
            Value = value;
        }
        public Union(T3 value)
        {
            Value = value;
        }
        public Union(T4 value)
        {
            Value = value;
        }
        public static implicit operator Union<T1, T2, T3, T4>(T1 value)
        {
            return new Union<T1, T2, T3, T4>(value);
        }
        public static implicit operator Union<T1, T2, T3, T4>(T2 value)
        {
            return new Union<T1, T2, T3, T4>(value);
        }
        public static implicit operator Union<T1, T2, T3, T4>(T3 value)
        {
            return new Union<T1, T2, T3, T4>(value);
        }
        public static implicit operator Union<T1, T2, T3, T4>(T4 value)
        {
            return new Union<T1, T2, T3, T4>(value);
        }
    }

    public class Union<T1, T2, T3, T4, T5> : Union
    {
        public Union(T1 value)
        {
            Value = value;
        }
        public Union(T2 value)
        {
            Value = value;
        }
        public Union(T3 value)
        {
            Value = value;
        }
        public Union(T4 value)
        {
            Value = value;
        }
        public Union(T5 value)
        {
            Value = value;
        }
        public static implicit operator Union<T1, T2, T3, T4, T5>(T1 value)
        {
            return new Union<T1, T2, T3, T4, T5>(value);
        }
        public static implicit operator Union<T1, T2, T3, T4, T5>(T2 value)
        {
            return new Union<T1, T2, T3, T4, T5>(value);
        }
        public static implicit operator Union<T1, T2, T3, T4, T5>(T3 value)
        {
            return new Union<T1, T2, T3, T4, T5>(value);
        }
        public static implicit operator Union<T1, T2, T3, T4, T5>(T4 value)
        {
            return new Union<T1, T2, T3, T4, T5>(value);
        }
        public static implicit operator Union<T1, T2, T3, T4, T5>(T5 value)
        {
            return new Union<T1, T2, T3, T4, T5>(value);
        }
    }

    public class Union<T1, T2, T3, T4, T5, T6> : Union
    {
        public Union(T1 value)
        {
            Value = value;
        }
        public Union(T2 value)
        {
            Value = value;
        }
        public Union(T3 value)
        {
            Value = value;
        }
        public Union(T4 value)
        {
            Value = value;
        }
        public Union(T5 value)
        {
            Value = value;
        }
        public Union(T6 value)
        {
            Value = value;
        }
        public static implicit operator Union<T1, T2, T3, T4, T5, T6>(T1 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6>(value);
        }
        public static implicit operator Union<T1, T2, T3, T4, T5, T6>(T2 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6>(value);
        }
        public static implicit operator Union<T1, T2, T3, T4, T5, T6>(T3 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6>(value);
        }
        public static implicit operator Union<T1, T2, T3, T4, T5, T6>(T4 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6>(value);
        }
        public static implicit operator Union<T1, T2, T3, T4, T5, T6>(T5 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6>(value);
        }
        public static implicit operator Union<T1, T2, T3, T4, T5, T6>(T6 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6>(value);
        }
    }

    public class Union<T1, T2, T3, T4, T5, T6, T7> : Union
    {
        public Union(T1 value)
        {
            Value = value;
        }
        public Union(T2 value)
        {
            Value = value;
        }
        public Union(T3 value)
        {
            Value = value;
        }
        public Union(T4 value)
        {
            Value = value;
        }
        public Union(T5 value)
        {
            Value = value;
        }
        public Union(T6 value)
        {
            Value = value;
        }
        public Union(T7 value)
        {
            Value = value;
        }
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7>(T1 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7>(value);
        }
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7>(T2 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7>(value);
        }
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7>(T3 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7>(value);
        }
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7>(T4 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7>(value);
        }
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7>(T5 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7>(value);
        }
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7>(T6 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7>(value);
        }
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7>(T7 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7>(value);
        }
    }

    public class Union<T1, T2, T3, T4, T5, T6, T7, T8> : Union
    {
        public Union(T1 value)
        {
            Value = value;
        }
        public Union(T2 value)
        {
            Value = value;
        }
        public Union(T3 value)
        {
            Value = value;
        }
        public Union(T4 value)
        {
            Value = value;
        }
        public Union(T5 value)
        {
            Value = value;
        }
        public Union(T6 value)
        {
            Value = value;
        }
        public Union(T7 value)
        {
            Value = value;
        }
        public Union(T8 value)
        {
            Value = value;
        }
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T1 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T2 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T3 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T4 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T5 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T6 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T7 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }
        public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T8 value)
        {
            return new Union<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }
    }
}
