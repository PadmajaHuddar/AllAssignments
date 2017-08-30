using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_DAY8
{
    public struct CoOrdsXY
    {
        int x, y;

        public CoOrdsXY(int p1, int p2)
        {
            x = p1;
            y = p2;
        }
    }
    public struct CoOrdsYZ
    {
        int y, z;

        public CoOrdsYZ(int p1, int p2)
        {
            y = p1;
            z = p2;
        }
    }
    class StructDemo
    {
        CoOrdsXY obj1 = new CoOrdsXY();
        CoOrdsXY obj11 = obj1;
        CoOrdsYZ obj2 = new CoOrdsYZ();
    }
}
