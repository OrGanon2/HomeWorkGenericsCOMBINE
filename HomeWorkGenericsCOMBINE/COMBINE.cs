using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkGenericsCOMBINE
{
    class COMBINE<T>
    {
        public string Combine(T[] Array1, T[] Array2)
        {
            int i = 0;
            T[] AllTypes = new T[Array1.Length + Array2.Length];

            foreach (var item in Array1)
            {
                AllTypes[i++] = item;
            }
            foreach (var item in Array2)
            {
                AllTypes[i++] = item;

            }
            return AllTypes.Length.ToString();
        }

    }
}
