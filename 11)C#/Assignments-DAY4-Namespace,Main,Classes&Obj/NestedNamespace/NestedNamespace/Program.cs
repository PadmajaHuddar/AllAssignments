using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedNamespace
{
    class Program
    {
        public static void Main()
        {
            Sample.print pp = new Sample.print();
            pp.WriteLine();
            global::System.Console.ReadLine();
            Demo.GlobalVar.Console gg = new Demo.GlobalVar.Console();
            gg.WriteLine();
        }
    }
    class Program2
    {
        static void Main(String[]args)
        {
            System.Console.WriteLine("Main method 2");
            Console.Read();
            Program.Main();
        }
    }
}

namespace Demo
{
    namespace GlobalVar
    {
        public class Console
        {
            public void WriteLine()
            {
                System.Console.WriteLine("Nested namespace printing");
                System.Console.ReadLine();
            }
        }
    }
}

namespace Sample
{
    public class print
    {
        public void WriteLine()
        {
            Console.WriteLine("Sample namespace");
            System.Console.ReadLine();
        }
    }
}