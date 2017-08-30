using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionLoopsDay3
{
    class Rectangle
    {
        public void printPattern()
        {
            try
            {
                Console.Write("Enter the number to print in Rectangle:");
                int number = Int32.Parse(Console.ReadLine());
                int i, j;
                int row_value = 5;
                int column_value = 3;
                for (i = 0; i < 5; i++)
                {
                    for (j = 0; j < 3; j++)
                    {
                        if (i == 0 || i == row_value - 1 || j == 0 || j == column_value - 1)
                            Console.Write("{0}", number);
                        else
                            Console.Write(" ");
                    }
                    Console.WriteLine("");
                }
                Console.Read();
            }
            catch
            {
                Console.WriteLine("Invalid Input");
                Console.Read();
            }
        }
    }
}
