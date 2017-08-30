using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class BoxingUnboxing
    {
        public void BoxUnbox()
        {
            int i = 20;
            object o = i;   //box the int
            i = 500;
            Console.WriteLine("i: {0} \nobj: {1}",i,o);
            int j = (int)o;  //unboxing it back into int
            Console.WriteLine("j: {0}",j);
            Console.Read();   
        }
    }
}
