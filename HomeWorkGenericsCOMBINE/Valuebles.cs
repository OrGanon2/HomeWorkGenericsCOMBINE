using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkGenericsCOMBINE
{
    class Valuebles<T> where T : struct
    {
        public T[] Value { get; set; } = new T[10];
        private int Count { get; set; }
       
        public void Additem(T item)
        {
            Value[Count] = item;
            Count--;
            Array.Sort(Value);
        }
       
        
    }
    
}
