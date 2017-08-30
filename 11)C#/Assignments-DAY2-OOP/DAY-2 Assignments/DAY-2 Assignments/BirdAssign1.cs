using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_2_Assignments
{
    class BirdAssign1                       //can also be implemented by abstract
    {
        public void BirdWalk()
        {
            Console.WriteLine("A bird can walk");
        }
    }
    class Bird1: BirdAssign1
    {
        public void BirdFly()
        {
            Console.WriteLine("First bird can fly");
            BirdWalk();
        }
    }
    class Bird2: BirdAssign1
    {
        public void BirdSing()
        {
            Console.WriteLine("Second bird can sing");
            BirdWalk();
        }
    }
}
