using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionLoopsDay3
{
    class ReverseString
    {
        public void reverse()
        {
            try
            {
                Console.Write("Enter the sentence: ");
                string sentence = Console.ReadLine();
                string[] arr = sentence.Split(' ');
                Array.Reverse(arr);
                string str = string.Join(" ", arr);
                Console.WriteLine(str);
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
