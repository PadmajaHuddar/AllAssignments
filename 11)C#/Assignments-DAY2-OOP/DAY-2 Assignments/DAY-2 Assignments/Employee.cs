using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_2_Assignments
{
    abstract class Employee
    {
        public int eid;
        public string ename;
        public string designation;
        public Employee(int empid, string empname, string empdesignation)
        {
            this.eid = empid;
            this.ename = empname;
            this.designation = empdesignation;
        }
        public abstract void salary(int no);
        public void display(int eid, string ename, string designation)
        {
            Console.WriteLine("Displaying information about {0} having Employee ID {1} and designation {2}", eid, ename, designation);
        }
    }
    class Admin : Employee
    {
        public Admin(int eid, string ename, string designation) : base(eid, ename,designation) { }
        public override void salary(int no)
        {
          //  display(eid, ename, designation);
            Console.WriteLine("Salary of Admin is :{0}", no * 5);
        }
    }
    class LabAssistant : Employee
    {
        public LabAssistant(int eid, string ename, string designation): base(eid, ename, designation) { }
        public override void salary(int no)
        {
            Console.WriteLine("Salary of Lab Assistant is :{0}", no * 2);
        }

    }
    class SoftwareEngg : Employee

    {
        public SoftwareEngg(int eid, string ename, string designation): base ( eid,  ename,  designation) { }
        public override void salary(int no)
        {
            Console.WriteLine("Salary of Software Engineer is :{0}", no * 4);
        }

    }
}
