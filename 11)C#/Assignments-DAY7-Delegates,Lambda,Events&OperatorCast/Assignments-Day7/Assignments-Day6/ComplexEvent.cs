using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_Day7
{
    public class TimeOfTick : EventArgs
    {
        private DateTime TimeNow;
        public DateTime Time
        {
            set
            {
                TimeNow = value;
            }
            get
            {
                return this.TimeNow;
            }
        }
    }
    public class ComplexEvent
    {
        public event TickHandler Tick;
        public delegate void TickHandler(ComplexEvent m, TimeOfTick e);
        public void Start()
        {
            while (true)
            {
                System.Threading.Thread.Sleep(1000);
                if (Tick != null)
                {
                    TimeOfTick TOT = new TimeOfTick();
                    TOT.Time = DateTime.Now;
                    Tick(this, TOT);
                }
            }
        }
    }
    public class ListenerEvent
    {
        public void Subscribe(ComplexEvent m)
        {
            m.Tick += new ComplexEvent.TickHandler(HeardIt);
        }
        private void HeardIt(ComplexEvent m, TimeOfTick e)
        {
            System.Console.WriteLine("HEARD IT AT {0}", e.Time);
        }

    }
    class Test1
    {
        static void Main()
        {
            ComplexEvent m = new ComplexEvent();
            ListenerEvent l = new ListenerEvent();
            l.Subscribe(m);
            m.Start();
        }
    }

}
