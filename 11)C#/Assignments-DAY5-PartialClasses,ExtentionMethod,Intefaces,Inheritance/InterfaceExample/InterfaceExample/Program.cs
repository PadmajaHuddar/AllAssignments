using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    interface ISampleInterface
    {
        void display();
    }
    class Program: ISampleInterface
    {
        static void Main(string[] args)
        {
            ISampleInterface i = new Program();
            i.display();
        }

        public void display()
        {
            Console.WriteLine("Displaying method in interface");
            Console.ReadLine();
        }
    }
}
