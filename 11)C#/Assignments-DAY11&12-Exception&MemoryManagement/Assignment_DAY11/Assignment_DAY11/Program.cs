using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_DAY11
{
    class Program
    {
        static void Main(string[] args)
        {
            ImplIDisposable obj = new ImplIDisposable();
            obj.fileIO();
            obj.Dispose();
            //UsingForDispose obj = new UsingForDispose();
            //obj.fileIO();

        }
    }
}
