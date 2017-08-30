using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionLoopsDay3
{
    class Diamond
    {
        public void diamond()
        {
            try
            {
                int i = 0;
                Console.Write("Enter the number of levels for Pyramid:");
                int level= Int32.Parse(Console.ReadLine());
                for (i = 0; i <= level; i++)
                {
                    for (int j = 1; j <= level - i; j++)
                        Console.Write(" ");
                    for (int j = 1; j <= 2 * i - 1; j++)
                        Console.Write("*");
                    Console.WriteLine();
                }

                for (i = level - 1; i >= 1; i--)
                {
                    for (int j = 1; j <= level - i; j++)
                        Console.Write(" ");
                    for (int j = 1; j <= 2 * i - 1; j++)
                        Console.Write("*");
                    Console.WriteLine();
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
