using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionLoopsDay3
{
    class PascalTrianglr
    {
        public void numberTriangle()
        {
            int i = 0, j = 0;
            Console.Write("Input number of rows : ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i <= n; i++)
            {
                for (j = 1; j <= n - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= i; j++)
                    Console.Write("{0}", j);
                for (j = i - 1; j >= 1; j--)
                    Console.Write("{0}", j);

                Console.Write("\n");
            }
            Console.Read();
        }
    }
}
