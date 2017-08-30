using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    abstract class AbstractClass
    {
        public abstract void eat();
        public void sound()
        {
            Console.WriteLine("Each animal has different sound");
        }
    }

    class Dog : AbstractClass
    {
        public override void eat()
        {
            Console.WriteLine("Dog eats bones");
        }
    }
}
