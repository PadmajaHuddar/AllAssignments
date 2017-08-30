using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo
{
    class SynchMechanismLock
    {
        static void Main(string[] arg)
        {
            Console.WriteLine("*****Multiple Threads*****");
            Printer p = new Printer();
            Thread[] Threads = new Thread[3];
            for (int i = 0; i < 3; i++)
            {
                Threads[i] = new Thread(new ThreadStart(p.PrintNumbers));
                Threads[i].Name = "Child " + i;
            }
            foreach (Thread t in Threads)
                t.Start();

            Console.ReadLine();
        }
    }
    //class Printer
    //{
    //    public void PrintNumbers()
    //    {
    //        for (int i = 0; i < 5; i++)
    //        {
    //            Thread.Sleep(100);
    //            Console.Write(i + ",");
    //        }
    //        Console.WriteLine();
    //    }
    //}
    class Printer
    {
        public void PrintNumbers()
        {
            lock (this)
            {
                for (int i = 0; i < 5; i++)
                {
                    Thread.Sleep(100);
                    Console.Write(i + ",");
                }
                Console.WriteLine();
            }
        }
    }

}
