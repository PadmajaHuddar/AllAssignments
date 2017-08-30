using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_2_Assignments
{
    class OverridingAssign3
    {
        public virtual void Notify()
        {
            Console.WriteLine("Notify via Email or SMS");
        }
    }
    class EmailNotify: OverridingAssign3
    {
        public override void Notify()
        {
            Console.WriteLine("Notification via Email");
        }
    }
    class SmsNotify: OverridingAssign3
    {
        public override void Notify()
        {
            Console.WriteLine("Notification via SMS");
        }
    }
}
