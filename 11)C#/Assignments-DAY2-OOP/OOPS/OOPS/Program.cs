using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Program
    {
        static void Main(string[] args)
        {
            //----Abstraction----
            /* Dog dog = new Dog();
             AbstractClass pet = dog;
             pet.eat();
             //dog.eat();
             dog.sound();
             Console.ReadLine();*/

            //----Inheritance----
            /*Scooter scooter = new Scooter();
             scooter.ScooterType();
             Car car = new Car();
             car.CarType();
             Console.ReadLine();*/

            //----Polymorphism Oveloading----
            /*PolymorphismClass calculator = new PolymorphismClass();
            calculator.Sum();
            calculator.Sum("Hello","World");
            calculator.Sum(1,5);
            calculator.Sum(1.5f, 5.5f);
            Console.ReadLine(); */

            //----Polymorphism Overriding----
            overriding over = new overriding();
            over = new DerivedOverrided();
            over.MyMethod();
            Console.ReadLine();
        }
    }
}
