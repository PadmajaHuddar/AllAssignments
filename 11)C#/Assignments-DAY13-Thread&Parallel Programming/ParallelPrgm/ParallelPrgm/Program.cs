using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelPrgm
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.For(0, 1000000, x => Function1());
            Console.ReadLine();
        }
        static void Function1()
        {
            Console.WriteLine("In function");
            Console.ReadLine();
        }
    }
}
