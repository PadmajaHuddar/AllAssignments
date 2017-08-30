using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo
{
    class PoolingDemo
    {
        static void Main(string[] args)
        {
            for (int x = 0; x < 10; x++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(ProcessFile), x);
            }
            Console.Read();
        }

        static void ProcessFile(Object n)
        {
            Console.WriteLine("{0} enters the Process", Thread.CurrentThread.Name);
            Thread.Sleep(300);
            Console.WriteLine("{0} is leaving the Process", Thread.CurrentThread.Name);
        }
    }
}
