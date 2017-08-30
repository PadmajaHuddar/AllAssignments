using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchDemo
{
    public class TemperatureZeroException : Exception
    {
        public TemperatureZeroException(string message) : base(message)
        { }
    }
    public class CustomException
    {
        int temp = 0;
        public void showTemp()
        {
            try
            {
                if (temp == 0)
                {
                    throw (new TemperatureZeroException("Zero temperature"));
                }
                else
                {
                    Console.WriteLine("Temperature is: {0}", temp);
                }
            }
            catch(TemperatureZeroException ex)
            {
                Console.WriteLine("{0}", ex);
            }
        }
    }
    
}
