using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class overriding
    {
        public virtual void MyMethod()
        {
            Console.WriteLine("This is the base class: First occurance");
        }
    }
    class DerivedOverrided: overriding
    {
        public override void MyMethod()
        {
            Console.WriteLine("This is the derived class: Next occurance");
        }
    }
}
