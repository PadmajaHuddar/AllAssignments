using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo
{
    class SynchMechanismMutex
    {
        private static Mutex mutex = new Mutex();
        private const int numhits = 1;
        private const int numThreads = 4;
        private static void ThreadProcess()
        {
            for (int i = 0; i < numhits; i++)
            {
                mutex.WaitOne();
                Console.WriteLine("{0} has entered in the Process",
                    Thread.CurrentThread.Name);
                Thread.Sleep(500);
                Console.WriteLine("{0} is leaving the Process",
                    Thread.CurrentThread.Name);
                mutex.ReleaseMutex();
            }
        }
      
        static void Main(string[] args)
        {
            for (int i = 0; i < numThreads; i++)
            {
                Thread mycorner = new Thread(new ThreadStart(ThreadProcess));
                mycorner.Name = String.Format("Thread{0}", i + 1);
                mycorner.Start();
            }
            Console.Read();
        }
    }
}
