using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_DAY8
{
    class TupleCls
    {
        public void TupleClass()
        {
            Tuple<int, string, bool> tuple = new Tuple<int, string, bool>(1, "cat", true);
            if (tuple.Item1 == 1)
            {
                Console.WriteLine(tuple.Item1);
            }
            if (tuple.Item2 == "dog")
            {
                Console.WriteLine(tuple.Item2);
            }
            if (tuple.Item3)
            {
                Console.WriteLine(tuple.Item3);
            }
            Console.ReadLine();
        }

        public void NestedTuple()
        {
            var primes = new Tuple<int, string , bool , int, int, int, int, Tuple<int, string>>(2, "hello", true, 7, 11, 13, 16, new Tuple<int,string>(19,"Padmaja"));
            Console.WriteLine("{0}", primes.Item1);
            Console.WriteLine("{0}", primes.Item2);
            Console.WriteLine("{0}", primes.Item3);
            Console.WriteLine("{0}", primes.Item4);
            Console.WriteLine("{0}", primes.Rest.Item1);
            Console.WriteLine("{0}", primes.Rest.Item2);
            Console.ReadLine();
        }
    }
}
