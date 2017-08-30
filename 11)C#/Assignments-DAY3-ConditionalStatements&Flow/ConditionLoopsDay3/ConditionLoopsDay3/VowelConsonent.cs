using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionLoopsDay3
{
    class VowelConsonent
    {
        public void vowelConsonent()
        {
            try
            {
                Console.Write("Enter an alphabet ");
                char alpha = Convert.ToChar(Console.ReadLine());
                if(alpha=='a'|| alpha == 'e' || alpha == 'i' || alpha == 'o' || alpha == 'u')
                {
                    Console.WriteLine("{0} is a vowel",alpha); 
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("{0} is a consonent",alpha);
                    Console.ReadLine();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input / Number too large(Try number less than 20)");
                Console.ReadKey();
            }
        }
    }
}
