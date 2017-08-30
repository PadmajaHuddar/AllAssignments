using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class BaseDerivedCast
    {
        public virtual void display()
        {
            Console.WriteLine("In base class");
            Console.ReadKey();
        }
    }
    class Derived: BaseDerivedCast
    {
        public override void display()
        {
            Console.WriteLine("In derived class");
            Console.ReadKey();
        }
    }
}
