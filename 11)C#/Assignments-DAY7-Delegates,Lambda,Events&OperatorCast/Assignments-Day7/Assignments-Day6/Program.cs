using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_Day7
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> EmployeeList = new List<Employee>();
            EmployeeList.Add(new Employee
            {
                EmpId = 1,
                Name = "Padmaja",
                ProjectName = "Twitter",
                Department = "Social networking"
            });
            EmployeeList.Add(new Employee
            {
                EmpId = 5,
                Name = "ABC",
                ProjectName = "IRCTC",
                Department = "Railway"
            });
            EmployeeList.Add(new Employee
            {
                EmpId = 6,
                Name = "BCD",
                ProjectName = "IRCTC",
                Department = "Railway"
            });
            EmployeeList.Add(new Employee
            {
                EmpId = 10,
                Name = "LMN",
                ProjectName = "Twitter",
                Department = "Social networking"
            });
            foreach (Employee emp in EmployeeList)
            {
                Console.WriteLine("List:{0}", emp.EmpId);
            }

            var emplList1 = EmployeeList.Select(c => new
            {
                Name = "ABC",
                Id = c.EmpId,
                Department = c.Department
            }).FirstOrDefault();

            Console.WriteLine(" Employee Name: {0} \n \n", emplList1);

            var emplList2 = EmployeeList.Where(c => c.EmpId > 5);
            Console.WriteLine("List for employees where EmployeeId > 5:");
            foreach (Employee emp in emplList2)
            {
                Console.WriteLine(" Employee Id: {0} \n Employee Name: {1} \n Department: {2} \n \n", emp.EmpId, emp.Name, emp.Department);
            }
            Console.ReadLine();

            var booleanGroupQuery =
           from emp in EmployeeList
           group emp by emp.Department;

            Console.WriteLine("Grouping by department:");
            foreach (var deptGroup in booleanGroupQuery)
            {
                foreach (var emp in deptGroup)
                {
                    Console.WriteLine(" Employee Id:{0}\n Employee Name: {1}\n Employee Department: {2}\n", emp.EmpId, emp.Name, emp.Department);
                }
            }
            Console.ReadLine();

            var emplList3= EmployeeList.Find(x => x.Name == "ABC");
            Console.WriteLine("\nFinding details of employee with name {0}: \n Employee Id: {1} \n Project Name: {2} \n Department: {3} \n \n", emplList3.Name, emplList3.EmpId, emplList3.ProjectName , emplList3.Department);
            
            Console.ReadLine();
        }
    }
}
