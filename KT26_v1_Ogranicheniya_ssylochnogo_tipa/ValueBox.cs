using System;
using System.Collections.Generic;
using System.Text;

namespace KT26v1
{
    public class ValueBox<T> where T : struct
    {
        private T? item = null;

        public bool IsEmpty => !item.HasValue;

        public void Set(T item)
        {
            this.item = item;
        }

        public T? Get()
        {
            return item;
        }
    }
}