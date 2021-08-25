using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkGenericsCOMBINE
{
    class ReadOnly<T> 
    {
        T[] ReadyForOnly = new T[10];
        public bool IsReadOnly { get; set; }
        public int Count { get; set; }

        public void ReadOnlyBool()
        {

            IsReadOnly =!IsReadOnly;
        }
        public void Add(T data)
        {
            if (IsReadOnly == true)
            {
                throw new InvalidOperationException("cant add items");
            }
            else
            {
                ReadyForOnly[Count++] = data;
            }
        }
    }
}
