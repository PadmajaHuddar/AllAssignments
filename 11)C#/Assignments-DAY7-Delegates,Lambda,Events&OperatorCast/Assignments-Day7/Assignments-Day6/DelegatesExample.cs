using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_Day7
{
    public delegate void DemoDelegate(int a, int b);
    class DelegatesExamples
    {

        public int subtract(int a, int b)
        {
            return (a - b);

        }

        public void division(int a, int b)
        {
            Console.WriteLine("Division={0}", (a / b));
        }
    }
    class Program1
    {
        static void Main(string[] args)
        {
            DelegatesExamples delegateobj = new DelegatesExamples();
            Func<int, int, int> sub = delegateobj.subtract;
            int result = sub(45, 30);
            Console.WriteLine("result ={0}", result);



            Action<int, int> div = new Action<int, int>(delegateobj.division);
            div(10, 5);

            DemoDelegate demo = delegate (int a, int b)
            {
                Console.WriteLine("Using anonymous delegate:{0}", (a + b));
            };

            demo(10, 90);

            DemoDelegate demo1 = (x, y) => { int add = x + y; Console.WriteLine("addition:{0}", add); };
            demo1(4, 3);

            Console.ReadLine();

        }
    }

}
