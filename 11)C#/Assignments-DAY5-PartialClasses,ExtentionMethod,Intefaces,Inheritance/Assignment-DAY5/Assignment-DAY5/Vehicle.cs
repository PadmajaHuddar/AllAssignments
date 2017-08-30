using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_DAY5
{
    class Vehicle
    {
        public static void Main(String[]args)
        {
            //Console.WriteLine("Area is: {0}", StaticClass.RectangleArea(5.5,6.5));     //calling a static class static method
            //Console.ReadLine();

            IVehicle truck1 = new TruckInterfaceImpl();
            truck1.start();
            IVehicle car1 = new CarInterfaceImpl();
            car1.stop();
            IVehicle scooter1 = new CarInterfaceImpl();
            scooter1.speed();
        }


        public int modelNo { get; set; }
        public string Name { get; set; }
        public string type { get; set; }
        public Vehicle(int _modelNo,string _Name, string _type)
        {
            modelNo = _modelNo;
            Name = _Name;
            type = _type;
        }
        public virtual void features() { }
        public void display()
        {
            Console.WriteLine("Vehicle details are as follows:\n Model Number:{0}\n Name:{1}\n Type:{2}",modelNo,Name,type);
            Console.Read();
        }
    }
    class Truck : Vehicle
    {
        public Truck(int modelNo,string Name, string type):base(modelNo, Name, type) { }
        public override void features()
        {
            Console.WriteLine("Truck can have 4 or more wheels. It cannot run at high speeds. Preferred for transportation of goods.");
            Console.Read();
        }
    }
    class Car: Vehicle
    {
        public Car(int modelNo, string Name, string type):base(modelNo, Name, type) { }
        public override void features()
        {
            Console.WriteLine("Cas has 4 wheels. It can run at high speeds. Preferred by long distance travel.");
            Console.Read();
        }
    }
    class Scooter: Vehicle
    {
        public Scooter(int modelNo, string Name, string type):base(modelNo, Name, type) { }
        public override void features()
        {
            Console.WriteLine("Scooter has 2 wheels. It can run at high speeds. Preferred for short distance travel.");
            Console.Read();
        }
    }
}
