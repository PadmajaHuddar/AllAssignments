using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class CheckedUnchecked
    {
        public void CheckedUncheckedOperator()
        {
            try
            {
                int a = 300000;
                int b = 200000;
                int c = checked(a * b);
                Console.WriteLine("Number is: {0}", c);
                Console.Read();
            }
            catch (Exception ex)
            {
                Console.Write("Exception occured: {0}", ex.Message);
                Console.Read();
            }
        }
    }
}
