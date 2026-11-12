using System;
using System.Collections.Generic;
using System.Text;

namespace KT26v1
{
    public class ReferenceBox<T> where T : class
    {
        private T? item = null;

        public bool IsEmpty => item == null;

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