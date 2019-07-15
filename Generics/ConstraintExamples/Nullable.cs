﻿namespace Generics.ConstraintExamples
{
    public class Nullable<T> where T : struct
    {
        private object _value;
        public Nullable()
        {

        }
        public Nullable(T value)
        {
            _value = value;
        }

        public bool HasValue { get =>_value !=null; }

        public T GetValueOrDefault()
        {
            if (HasValue) return (T)_value;
            else return default(T);
        }
    }
}
