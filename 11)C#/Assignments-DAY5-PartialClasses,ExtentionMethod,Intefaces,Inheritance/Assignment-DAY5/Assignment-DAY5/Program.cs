using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_DAY5
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pg = new Program();
            //pg.swap();
            //pg.table();
            //pg.removeVowel();
            //pg.FirstUpper();
            //Console.Write("Enter a string: ");
            //string str = Console.ReadLine();
           // Console.WriteLine(str.ToTitleCase());
           // Console.Read();


            //Vehicle veh;
            //veh = new Truck(889,"Mahindra","Goods & Transport");
            //veh.features();
            //veh.display();

            //veh = new Car(778, "Ertiga", "SUV");
            //veh.features();
            //veh.display();

            //veh = new Scooter(19, "Duke", "Sports bike");
            //veh.features();
            //veh.display();


        }

        public void swap()
        {
            try
            {
                Console.Write("Enter number:");
                int no1 = Int32.Parse(Console.ReadLine());
                Console.Write("Enter number:");
                int no2 = Int32.Parse(Console.ReadLine());
                int temp;
                temp = no1;
                no1 = no2;
                no2 = temp;
                Console.WriteLine("Swapped numbers is number1: {0}, number2: {1}", no1, no2);
                Console.Read();
            }
            catch(Exception)
            {
                Console.WriteLine("Invalid Input");
                Console.Read();

            }
        }
        public void table()
        {
            try
            {
                Console.Write("Enter number:");
                int no = Int32.Parse(Console.ReadLine());
                for(int i=1;i<=10;i++)
                {
                    Console.WriteLine("{0}*{1}={2}", no, i, (no * i));
                }
                Console.Read();
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input");
                Console.Read();

            }
        }
        public void removeVowel()
        {
            try
            {
                Console.Write("Enter a string: ");
                string str = Console.ReadLine();
                var result = string.Join("", str.Split('a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U').Distinct());
                Console.WriteLine("Result after removing vowels: {0}", result);
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input");
                Console.ReadKey();
            }
        }
       
    }
    public static class Extension
    {
        public static string ToTitleCase(this string str)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
        }
    }
}
