using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionLoopsDay3
{
    class LongestWord
    {
       
            String[] charArray;
            char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
            public void longestWordInString()
        {
            Console.Write("Enter the sentence:");
            string str = Console.ReadLine();
            int i = 0, j = 0, max = 0;
                charArray = str.Split(delimiterChars);

                foreach (string s in charArray)
                {
                    if (max < s.Length)
                    {
                        max = s.Length;
                        j = i;
                    }
                    i++;
                }

                Console.WriteLine("Word with max. length is = " + charArray[j]);
                Console.Read();
            }
        

    }
}
