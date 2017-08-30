using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Assignments
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pg = new Program();
            //pg.Pyramid();
            //pg.Palindrome();
            pg.duplicateRemoval();
        }
        public void Pyramid()
        {
            try
            {
                int i = 0;
                Console.Write("Enter the number of levels for Pyramid:");
                int level = Int32.Parse(Console.ReadLine());
                if (level > 20)
                {
                    throw new ArgumentOutOfRangeException("Number is large");
                }
                /* while (i <= level)
                 {
                     for (int j = i; j < level; j++)
                     {
                         Console.Write(" ");
                     }
                     for (int j = 1; j <= i; j++)
                     {
                         Console.Write("*");
                     }
                     i++;
                     Console.WriteLine();
                 }*/
                for (i = 1; i <= level; i++)
                {
                    Console.WriteLine("{0}{1}", (new string(' ', level - i)), (new string('*', i)));
                }


                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input / Number too large(Try number less than 20)");
                Console.ReadKey();
            }
        }

        public void Palindrome()
        {
            try
            {
                int flg = 0, i = 0, j = 0;
                Console.WriteLine("Enter a string: ");
                string str = Console.ReadLine();
                for (i = 0, j = str.Length; i <= (str.Length / 2); i++)
                {
                    if (str[i] != str[j - i - 1])
                    {
                        flg = 0;
                        Console.WriteLine("Entered string is not a palindrome");
                        break;
                    }
                    else
                    {
                        flg = 1;
                    }
                }
                if (flg == 1)
                {
                    Console.WriteLine("Entered string is a palindrome");
                }
                Console.Read();
            }

            catch (Exception)
            {
                Console.WriteLine("Invalid input");
                Console.ReadKey();
            }
        }

        public void duplicateRemoval()
        {
            try
            {
                Console.WriteLine("Enter a string: ");
                string str = Console.ReadLine();
                if (str==" ")
                {
                    throw new FormatException();
                }
                var result = string.Join(" ",str.Split(' ').Distinct());
                Console.WriteLine(result);
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input");
                Console.ReadKey();
            }
        }
    }
}
