using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo
{
    class MultipleThreads
    {
        public static void Main(string[] args)
        {
            Thread thread1 = new Thread(new ThreadStart(DisplayThread1));
            Thread thread2 = new Thread(new ThreadStart(DisplayThread2));
            thread1.Start();
            thread2.Start();
        }
        private static string _threadOutput = "";
        private static bool _stopThreads;

        static void DisplayThread1()
        {
            while (_stopThreads == false)
            {
                Console.WriteLine("Display Thread 1");
                _threadOutput = "Hello Thread1";
                Thread.Sleep(1000); 
                Console.WriteLine("Thread 1 Output --> {0}", _threadOutput);
            }
        }
        static void DisplayThread2()
        {
            while (_stopThreads == false)
            {
                Console.WriteLine("Display Thread 2");
                _threadOutput = "Hello Thread2";
                Thread.Sleep(1000);
                Console.WriteLine("Thread 2 Output --> {0}", _threadOutput);
            }
        }
    }
}
