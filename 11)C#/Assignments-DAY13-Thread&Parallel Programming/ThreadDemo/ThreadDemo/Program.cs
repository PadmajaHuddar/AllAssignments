using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread obj = new Thread(Function1);
            obj.Start();
            Console.WriteLine("In main");
        }
        static void Function1()
        {
            Console.WriteLine("Function1 execution start");
            Console.ReadLine();
            Console.WriteLine("Function1 execution end");
            Console.ReadLine();
        }
    }
}


//internal threads made by thread class
//win app/form & console application creates exe which is a single standalome app