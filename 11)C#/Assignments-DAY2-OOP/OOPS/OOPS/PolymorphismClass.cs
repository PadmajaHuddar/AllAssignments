using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class PolymorphismClass
    {
        public void Sum()                                       //overloading
        {
            Console.WriteLine("No value provided");
        }
        public void Sum(int a, int b)       
        {
            Console.WriteLine("Sum of {0} and {1} is {2}",a,b,(a+b));
        }
        public void Sum(float a, float b)
        {
            Console.WriteLine("Sum of {0} and {1} is {2}", a, b, (a + b));
        }
        public void Sum(string a, string b)
        {
            Console.WriteLine("Sum of {0} and {1} is {2}", a, b, (a + b));
        }
    }
}
