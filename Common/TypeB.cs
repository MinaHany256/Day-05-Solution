using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    internal class TypeB
    {
        public TypeB() 
        {
            TypeA obj = new TypeA();
            //obj.x = 10;  // invalid due to protection level (x is private)

            //obj.y = 1;  // valid
            
            obj.z = 0;    // valid
        }
    }
}
