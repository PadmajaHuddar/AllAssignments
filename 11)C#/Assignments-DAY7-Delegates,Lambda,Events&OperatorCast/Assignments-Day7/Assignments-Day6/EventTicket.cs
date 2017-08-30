using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_Day7
{
    public class EventTicket
    {
        public event TickHandler Tick;
        public EventArgs e = null;
        public delegate void TickHandler(EventTicket m, EventArgs e);
        public void Start()
        {
            while (true)
            {
                System.Threading.Thread.Sleep(1000);
                if (Tick != null)
                {
                    Tick(this, e);
                }
            }
        }
    }
    public class Listener
    {
        public void Subscribe(EventTicket m)
        {
            m.Tick += new EventTicket.TickHandler(HeardIt);
        }
        private void HeardIt(EventTicket m, EventArgs e)
        {
            System.Console.WriteLine("HEARD IT");
        }

    }
    class Test
    {
        static void Main()
        {
            EventTicket m = new EventTicket();
            Listener l = new Listener();
            l.Subscribe(m);
            m.Start();
            Console.ReadLine();
        }
    }
}
