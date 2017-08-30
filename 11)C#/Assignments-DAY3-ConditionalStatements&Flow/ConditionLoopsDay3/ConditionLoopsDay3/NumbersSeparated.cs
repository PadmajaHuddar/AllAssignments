using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionLoopsDay3
{
    class NumbersSeparated
    {
         public void numbersSeparated()
        {
            try
            {
                 Console.Write("Enter the number: ");
                 char no = Convert.ToChar(Console.ReadLine());
                 for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write("{0}{1}", new string(no, 1), new string(' ', 1));
                    }
                    Console.WriteLine();
                    Console.WriteLine("{0}",new string (no, 4));
                }
                Console.ReadLine();

            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input");
                Console.ReadLine();
            }
        }
    }
}
