using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class ImplicitExplicit
    {
        public void ExplicitConversion()
        {
            try
            {
                long val = 3000000000;
                int i = checked((int)val);
                Console.Write("Value is {0}", i);
                Console.Read();
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                Console.Read();

            }
        }
    }
}
