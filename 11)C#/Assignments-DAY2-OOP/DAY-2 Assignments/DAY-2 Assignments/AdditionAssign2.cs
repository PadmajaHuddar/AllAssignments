using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_2_Assignments
{
    class AdditionAssign2
    {
        public void sum(int a, int b)
        {
            Console.WriteLine("Addition of {0} and {1} is : {2}", a, b, (a + b));
        }
        public void sum(int a, int b, int c)
        {
            Console.WriteLine("Addition of {0},{1} and {2} is : {3}", a, b, c, (a + b + c));
        }
        public void sum(int a, int b, int c, int d)
        {
            Console.WriteLine("Addition of {0},{1},{2} and {3} is : {4}", a, b, c, d, (a + b + c + d));
        }
    }
}
