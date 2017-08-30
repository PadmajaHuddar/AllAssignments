using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            PartialClass pclass1 = new PartialClass("Padmaja");
            PartialClass pclass2 = new PartialClass(1,"Padmaja");
            pclass1.display();
            pclass2.displayDetails();
            Console.Read();          
            Console.WriteLine("Area is: {0}", StaticExample.AreaCalc(9.0));     //calling a static class static method
            Console.ReadLine();
            string str = "Hello all. Today is Friday,11th.";
            Console.WriteLine(str.UpperCase());
            Console.WriteLine(str.LowerCase());
            Console.ReadKey();
        }
    }
}

//when same method name from base used in derived with new then method hiding
