using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_DAY5
{
    interface IVehicle
    {
        void start();
        void stop();
        void speed();
    }
    class InterfaceSample
    {
    }
    class TruckInterfaceImpl : IVehicle
    {
        public void speed()
        {
            Console.WriteLine("Speed of truck is 40km/hr");
            Console.Read();
        }

        public void start()
        {
            Console.WriteLine("Taking off");
            Console.Read();
        }

        public void stop()
        {
            Console.WriteLine("stopping");
            Console.Read();
        }
    }
    class CarInterfaceImpl : IVehicle
    {
        public void speed()
        {
            Console.WriteLine("Speed of car is 80km/hr");
            Console.Read();
        }

        public void start()
        {
            Console.WriteLine("Taking off");
            Console.Read();
        }

        public void stop()
        {
            Console.WriteLine("stopping");
            Console.Read();
        }
    }
    class ScooterInterfaceImpl : IVehicle
    {
        public void speed()
        {
            Console.WriteLine("Speed of scooter is 70km/hr");
            Console.Read();
        }

        public void start()
        {
            Console.WriteLine("Taking off");
            Console.Read();
        }

        public void stop()
        {
            Console.WriteLine("stopping");
            Console.Read();
        }
    }
}
