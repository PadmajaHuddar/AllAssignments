using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLib;

namespace ExceptionHandling
{
    class Calci
    {
        public void calculate()
        {
            Class1 obj = new Class1();
            try
            {
                Console.Write("Enter First Number:");
                int no1 = Int32.Parse(Console.ReadLine());
                Console.Write("Enter Second Number:");
                int no2 = Int32.Parse(Console.ReadLine());
                int result = 0;
                if(no1<0||no2<0)
                {
                    throw (new NewException("Negative number entered"));
                }
                while (true)
                {
                    Console.WriteLine("Choose among:\n 1) Addition \n 2) Substraction \n 3) Multiplication \n 4) Division \n 5) Exit");
                    Console.Write("Input your choice:");
                    int option = Int32.Parse(Console.ReadLine());
                    if (option == 5)
                    {
                        Console.WriteLine("Exiting");
                        Console.ReadLine();
                        break;
                    }
                    switch (option)
                    {
                        case 1:
                            result = obj.add(no1, no2);
                            Console.WriteLine("The addition of {0} and {1} is {2}", no1, no2, result);
                            Console.ReadLine();
                            break;
                        case 2:
                            result = obj.subtract(no1, no2);
                            Console.WriteLine("The substraction of {0} and {1} is {2}", no1, no2, result);
                            Console.ReadLine();
                            break;
                        case 3:
                            result = obj.multiply(no1, no2);
                            Console.WriteLine("The multiplication of {0} and {1} is {2}", no1, no2, result);
                            Console.ReadLine();
                            break;
                        case 4:
                            result = obj.divide(no1, no2);
                            Console.WriteLine("The division of {0} and {1} is {2}", no1, no2, result);
                            Console.ReadLine();
                            break;
                    }
                }
            }
            catch (NewException ex)
            {
                Console.WriteLine("NewException occured: {0}", ex);
                Console.ReadLine();
            }

            catch (FormatException ex)
            {
                Console.WriteLine("FormatException occured: {0}", ex);
                Console.ReadLine();
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine("InvalidCastException occured: {0}", ex);
                Console.ReadLine();
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("NullReferenceException occured: {0}", ex);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occured: {0}", ex);
                Console.ReadLine();
            }
        }
    }
}
