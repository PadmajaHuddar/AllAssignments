using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionLoopsDay3
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pg = new Program();
            //pg.Farenheit();
            //pg.prime();
            //pg.sumOfDigit();
            //pg.leapYear();
            NumbersSeparated num = new NumbersSeparated();
            //num.numbersSeparated();            //1
            Rectangle rect = new Rectangle();
           // rect.printPattern();                //2
            ReverseString reverse = new ReverseString();
          //  reverse.reverse();                //7
            Temperature temp = new Temperature();
            //temp.temperatureInfo();            //10
            VowelConsonent check = new VowelConsonent();
            //check.vowelConsonent();           //11
            Calculator calc = new Calculator();
            //calc.calculator();                //13
            Diamond diamonds = new Diamond();
            //diamonds.diamond();
            //pg.sixTriangle();
            // pg.cube();
            DecimalToBinary dec = new DecimalToBinary();
            //dec.decimalBin();
            PascalTrianglr triangle = new PascalTrianglr();
            //triangle.numberTriangle();
           // pg.largestWord();
            // pg.largestNumber();         //9
            ElectricityBill bill = new ElectricityBill();
            //bill.billCalculate();
            LongestWord word = new LongestWord();
            word.longestWordInString();
        }

         



        public void Farenheit()
        {
            try
            {
                Console.Write("Enter temperature in degree celsius: ");
                double temperature = Convert.ToDouble(Console.ReadLine());
                double farenheitValue = temperature * 1.8 + 32;
                Console.Write("Temperature in Farenheit: {0}", farenheitValue);
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input");
                Console.ReadLine();
            }
        }


        public void largestWord()
        {
            try
            {
                Console.Write("Enter the sentence: ");
                var sentence = Console.ReadLine();
                var words = sentence.Split(' ');
                var finalValue = sentence.OrderByDescending(word => words.Length).First();
                Console.WriteLine("Longest word: " + finalValue);
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input");
                Console.ReadLine();
            }
        }


        public void prime()
        {
            int number = 2;
            int count = 0;
            long sum = 0;
            while (count < 500)
            {
                if (isPrimeNumber(number))
                {
                    sum += number;
                    count++;
                    Console.WriteLine("Number {0}, Count {1}, Sum {2}", number, count, sum);
                }
                number++;
            }
            Console.WriteLine("Sum of first 500 prime numbers is {0}", sum);
            Console.ReadLine();
        }

        private static bool isPrimeNumber(int number)
        {

            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }



        public void sumOfDigit()
        {
            try
            {
                Console.Write("Enter the number: ");
                int no = Int32.Parse(Console.ReadLine());
                int sum = 0;
                while (no != 0)
                {
                    sum = sum + (no % 10);
                    no = no / 10;
                }
                Console.WriteLine("Sum is {0}", sum);
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input");
                Console.ReadLine();
            }
        }

        public void leapYear()
        {
            try
            {
                Console.Write("Enter the number: ");
                int no = Int32.Parse(Console.ReadLine());
                if (no % 4 == 0)
                {
                    Console.WriteLine("{0} is a Leap Year", no);
                    Console.ReadLine();
                }
                else if (no % 400 == 0)
                {
                    Console.WriteLine("{0} is a Leap Year", no);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("{0} is not a Not a leap Year", no);
                    Console.ReadLine();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input");
                Console.ReadLine();
            }
        }

        public void largestNumber()
        {
            try
            {
                Console.Write("Enter the 1st number: ");
                int no1 = Int32.Parse(Console.ReadLine());
                Console.Write("Enter the 2nd number: ");
                int no2 = Int32.Parse(Console.ReadLine());
                Console.Write("Enter the 3rd number: ");
                int no3 = Int32.Parse(Console.ReadLine());
                if(no1>no2 && no1> no3)
                {
                    Console.WriteLine("Number 1 is greater than {0} & {1}",no2,no3);
                    Console.ReadLine();
                }
                else if(no2>no3)
                {
                    Console.WriteLine("Number 2 is greater than {0} & {1}", no1, no3);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Number 3 is greater than {0} & {1}", no1, no2);
                    Console.ReadLine();
                }
            }

            catch (Exception)
            {
                Console.WriteLine("Invalid Input");
                Console.ReadLine();
            }
        }

        public void sixTriangle()
        {
            try
            {
                int i = 0;
                Console.Write("Enter the number to be displayed in Pyramid:");
                char no = Convert.ToChar(Console.ReadLine());
                Console.Write("Enter the number of levels for Pyramid:");
                int level = Int32.Parse(Console.ReadLine());
                if (level > 20)
                {
                    throw new ArgumentOutOfRangeException("Number is large");
                }
                for (i = 0; i < level; i++)
                {
                    Console.WriteLine("{0}{1}", (new string(no, level - i)), (new string(' ', i)));
                }
                Console.ReadKey();

            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input / Number too large(Try number less than 20)");
                Console.ReadKey();
            }
        }

        public void cube()
        {
            try
            {
                Console.Write("Enter the number: ");
                int no = Int32.Parse(Console.ReadLine());
                for (int i = 1; i <= no; i++)
                {
                    Console.WriteLine("Number is : {0} and cube of {1} is :{2} ", i, i, (i * i * i));
                }
                Console.Read();
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input / Number too large(Try number less than 20)");
                Console.ReadKey();
            }
        }

        
    }
}
