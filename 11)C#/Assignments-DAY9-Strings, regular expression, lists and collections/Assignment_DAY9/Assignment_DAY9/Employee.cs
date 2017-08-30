using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_DAY9
{
    public class Employee
    {
        string name;
        int id;
        int salary;

        public Employee(string s, int i, int sal)
        {
            name = s;
            id = i;
            salary = sal;
        }
        public string EmployeeData
        {
            get { return String.Format("{0} with Employee Id {1} has salary {2}.", name, id, salary); }
        }
    }

    public class EmployeeCollection<T> : IEnumerable<T>
    {
        List<T> empList = new List<T>();

        public void AddEmployee(T e)
        {
            empList.Add(e);
        }

        public T GetEmployee(int index)
        {
            return empList[index];
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        //Compile time Error
        public void PrintEmployeeData(int index)
        {
            Console.WriteLine(EmployeeData);
        }

        //foreach support
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return empList.GetEnumerator();
        }
        
    }
}
