using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_Day7
{
    public delegate void CalculateSimpleInterest(int p, int n);


    class SimpleInterest
    {
        int r;

        public void getTotalInterest(int p, int n/*,int r*/)
        {
            int si = 0;
            si = (p * n * r) / 100;
            Console.WriteLine("Principle:{0}\nNumber of years:{1}\nRate of interest:{2}", p, n, r);
            Console.WriteLine("Simple Interest:{0}", si);

        }

        public void getInterestRatePerYear(int p, int n)
        {
            Console.WriteLine("Enter rate of interest per year");
            r = Convert.ToInt32(Console.ReadLine());

        }
    }

    class Program2
    {
        static void Main(string[] args)
        {
            SimpleInterest SIobj = new SimpleInterest();
            CalculateSimpleInterest si = new CalculateSimpleInterest(SIobj.getTotalInterest);
            CalculateSimpleInterest rate = new CalculateSimpleInterest(SIobj.getInterestRatePerYear);
            CalculateSimpleInterest result;


            Console.WriteLine("Enter principle amount");
            int p = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number of years");
            int n = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine("Enter rate of interest");
            //int r = Convert.ToInt32(Console.ReadLine());
            rate(p, n);
            result = si + rate;
            si(p, n);


            Console.ReadLine();
        }
    }

}
