using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public static class StaticExample
    {
        public static double AreaCalc(double no)
        {
            no = no*no;
            return no;
        }
    }
}

/*class is prefixed static and all the methods are static used when same operation to be performed not much change (eg: calc area)*/