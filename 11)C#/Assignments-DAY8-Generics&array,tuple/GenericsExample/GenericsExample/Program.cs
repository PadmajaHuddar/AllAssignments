using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20;
            float c= 10.90F, d= 20.89F;
            string str1 = "hello", str2 = "world";
            GenericClass obj = new GenericClass();
            obj.Swap<int>(ref a,ref b);
            obj.Swap<float>(ref c,ref d);
            obj.Swap<string>(ref str1,ref str2);
        }
    }
}
