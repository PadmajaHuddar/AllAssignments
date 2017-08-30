using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionLoopsDay3
{
    class Calculator
    {
        public void calculator()
        {
            try
            {
                Console.WriteLine("Enter First Number:");
                int no1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter Second Number:");
                int no2 = Int32.Parse(Console.ReadLine());
                
                while (true)
                {
                    Console.WriteLine("Choose among:\n 1) Addition \n 2) Substraction \n 3) Multiplication \n 4) Division \n 5) Exit");
                    Console.Write("Input your choice:");
                    int option = Int32.Parse(Console.ReadLine());
                    if(option==5)
                    {
                        Console.WriteLine("Exiting");
                        Console.ReadLine();
                        break;
                    }
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("The addition of {0} and {1} is {2}", no1, no2, (no1 + no2));
                            Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("The substraction of {0} and {1} is {2}", no1, no2, (no1 - no2));
                            Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("The multiplication of {0} and {1} is {2}", no1, no2, (no1 * no2));
                            Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("The division of {0} and {1} is {2}", no1, no2, (no1 / no2));
                            Console.ReadLine();
                            break;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input");
                Console.ReadLine();
            }
        }

    }
}
