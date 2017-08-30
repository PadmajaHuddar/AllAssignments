using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace NewConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var dept = new DepartmentContext())
            {
                Console.WriteLine("Add department");
                var deptObj = new DepartmentLib { ID = 1, Name = "IT", Location = "Pune"};
                dept.Departments.Add(deptObj);
                dept.SaveChanges();
                Console.WriteLine("Department Created");

                Console.ReadLine();
            }
        }
    }
}
