using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo
{
    class SynchMechanismSemaphore
    {
        static Thread[] threads = new Thread[10];
        static Semaphore sem = new Semaphore(3, 3);

        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                threads[i] = new Thread(Process);
                threads[i].Name = "Thread no. " + i;
                threads[i].Start();
            }
            Console.ReadLine();
        }

        static void Process()
        {
            Console.WriteLine("{0} is waiting in line...", Thread.CurrentThread.Name);
            sem.WaitOne();
            Console.WriteLine("{0} enters the Process", Thread.CurrentThread.Name);
            Thread.Sleep(300);
            Console.WriteLine("{0} is leaving the Process", Thread.CurrentThread.Name);
            sem.Release();
        }
    }
}
