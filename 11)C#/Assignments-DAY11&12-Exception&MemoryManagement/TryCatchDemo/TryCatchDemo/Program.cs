using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //DivideByZeroExcep obj = new DivideByZeroExcep();
            //obj.calculate();
            //Console.ReadLine();
            CustomException obj1 = new CustomException();
            obj1.showTemp();
            Console.ReadLine();
        }
    }
}
