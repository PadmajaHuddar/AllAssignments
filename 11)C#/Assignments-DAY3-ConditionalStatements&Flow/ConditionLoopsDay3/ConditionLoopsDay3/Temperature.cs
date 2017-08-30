using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionLoopsDay3
{
    class Temperature
    {
        public void temperatureInfo()
        {
            try
            {
                Console.Write("Enter the temperature:");
                int temp = Int32.Parse(Console.ReadLine());
                if(temp<0)
                {
                    Console.WriteLine("Freezing weather");
                    Console.ReadLine();
                }
                else 
                if(temp>=0 && temp<10)
                {
                    Console.WriteLine("Very Cold weather");
                    Console.ReadLine();
                }
                else
                if (temp >= 10 && temp < 20)
                {
                    Console.WriteLine("Cold weather");
                    Console.ReadLine();
                }
                else
                if (temp >= 20 && temp < 30)
                {
                    Console.WriteLine("Normal in Temp");
                    Console.ReadLine();
                }
                else
                if (temp >= 30 && temp < 40)
                {
                    Console.WriteLine("Its Hot");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Its Very Hot");
                    Console.ReadLine();
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
