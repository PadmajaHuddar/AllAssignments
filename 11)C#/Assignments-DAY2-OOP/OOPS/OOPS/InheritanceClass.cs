using System;

namespace OOPS
{
    public class InheritanceClass
    {
        public void TyreType()
        {
            Console.WriteLine("Tubeless tyres");
        }
    }
    public class Scooter: InheritanceClass
    {
        public void ScooterType()
        {
            Console.WriteLine("Scooter color is blue");
            TyreType();
        }
    }
    public class Car: InheritanceClass
    {
        public void CarType()
        {
            Console.WriteLine("Car color is blacK");
            TyreType();
        }
    }
}
