using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchDemo
{
    class DivideByZeroExcep
    {
        public void calculate()
        {
            Console.Write("Enter 1st number:");
            int no1 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter 2nd number:");
            int no2 = Int32.Parse(Console.ReadLine());
            int result = 0;
            try
            {
                result = no1 / no2;
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Exception Occured. {0}", ex);
            }
            finally
            {
                Console.WriteLine("Result is: {0}", result);
            }
        }
    }
}
