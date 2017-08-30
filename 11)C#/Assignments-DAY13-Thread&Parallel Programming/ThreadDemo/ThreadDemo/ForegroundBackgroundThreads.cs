using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo
{
    class ForegroundBackgroundThreads
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********** Foreground Vs Background**********");
            Console.WriteLine();
            Console.WriteLine("Enter 1 to Start Foreground Thread and 2 Start Background Thread: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine();
            switch (number)
            {
                case 1:
                    RunningForegroundThread();
                    break;
                case 2:
                    RunningBackgroundThread();
                    break;
                default:
                    break;
            }
            Console.WriteLine("Main execution completed..");
        }

        static void Delay()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Running......");
                Thread.Sleep(1000);
            }
        }

        static void RunningForegroundThread()
        {
            Thread foreground = new Thread(Delay);
            foreground.Start();
        }

        static void RunningBackgroundThread()
        {
            Thread background = new Thread(Delay);
            background.IsBackground = true;
            background.Start();
        }
    }
}
