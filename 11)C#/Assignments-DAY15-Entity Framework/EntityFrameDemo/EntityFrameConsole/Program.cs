using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameDemo;

namespace EntityFrameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var EmpObj = new EmployeesEntities1())
            {
                var emp = new EmpDetail();
                //emp.EmpId = 1;
                //emp.Name = "Abc-Emp1";
                //emp.Salary = "100000";
                //EmpObj.EmpDetails.Add(emp);
                
                //emp.EmpId = 2;
                //emp.Name = "Pqr-Emp2";
                //emp.Salary = "300000";
                //EmpObj.EmpDetails.Add(emp);

                //for (int i = 3; i < 5; i++)
                //{
                //    emp.EmpId = i;
                //    emp.Name = "Pqr-Emp"+i;
                //    emp.Salary = "300000";
                //    EmpObj.EmpDetails.Add(emp);
                //}
                EmpDetail EmpObj1 = EmpObj.EmpDetails.First(i => i.EmpId == 2);
                EmpObj1.Name = "Emp2";
                EmpObj.SaveChanges();

                Console.WriteLine("Records Inserted");
                Console.ReadLine();
            }
        }
    }
}
