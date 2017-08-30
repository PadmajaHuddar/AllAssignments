using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_2_Assignments
{
    class Program
    {
        static void Main(string[] args)
        {
            //---DAY-2 Assignment1---
            /*BirdAssign1 bird = new BirdAssign1();
            Bird1 bird1 = new Bird1();
            bird1.BirdFly();
            Bird2 bird2 = new Bird2();
            bird2.BirdSing();
            Console.ReadKey();*/

            //---DAY-2 Assignment2---
            /*AdditionAssign2 add = new AdditionAssign2();
            add.sum(2, 5);
            add.sum(5, 8, 3);
            add.sum(15, 5, 20);
            Console.ReadLine();
            add.sum(Int32.Parse(args[0]),Int32.Parse(args[1]));
            Console.ReadLine();
            add.sum(Int32.Parse(args[0]), Int32.Parse(args[1]), Int32.Parse(args[2]));
            Console.ReadLine();
            add.sum(Int32.Parse(args[0]), Int32.Parse(args[1]), Int32.Parse(args[2]), Int32.Parse(args[3]));
            Console.ReadKey();*/

            //---DAY-2 Assignment3---
            /*Console.WriteLine("Select 1 for Email Notifications and 2 for SMS Notifications");
            string input = Console.ReadLine();
            OverridingAssign3 over = new OverridingAssign3();

            if (Int32.Parse(input) == 1)
            {
                over = new EmailNotify();
                over.Notify();
                Console.ReadKey();
            }
            else
            {

                over = new SmsNotify();
                over.Notify();
                Console.ReadKey();
            }*/

            //---Employee Class---
            Console.WriteLine("Select one of:\n 1) Admin \n 2) Lab Assistant \n 3) Software Engg");
            string input = Console.ReadLine();
            Employee emp;
            if(Int32.Parse(input)==1)
            {
                emp = new Admin(101,"ABC","Admin");
                emp.display(101, "ABC", "Admin");
                emp.salary(500);
                Console.ReadKey();
            }
            else 
            if (Int32.Parse(input) == 2)
            {
                emp = new LabAssistant(101, "ABC", "LabAssistant");
                emp.display(101, "ABC", "LabAssistant");
                emp.salary(500);
                Console.ReadKey();
            }
            else 
            if (Int32.Parse(input) == 3)
            {
                emp = new SoftwareEngg(101, "ABC", "SoftwareEngg");
                emp.display(101, "ABC", "SoftwareEngg");
                emp.salary(500);
                Console.ReadKey();
            }
        }
    }
}
