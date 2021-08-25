using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkGenericsCOMBINE
{
    interface INames
    { 
        public string Name { get; set; }
    }
    class ClassesName : INames
    {
        public string Name { get; set; } = "Names";
        public string printname()
        {
            return Name;
        }
        public override string ToString()
        {
            return GetType().Name; 
        }
    }
    
}
