using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ServiceDemo
{
    public partial class ServiceDemo : ServiceBase
    {
        public ServiceDemo()
        {
            InitializeComponent();
            if (!System.Diagnostics.EventLog.SourceExists("ServiceDemoSource"))
                System.Diagnostics.EventLog.CreateEventSource("ServiceDemoSource", "ServiceDemoLog");

            eventLog1.Source= "ServiceDemoSource";
            eventLog1.Log = "ServiceDemoLog";
        }

        protected override void OnStart(string[] args)
        {
            eventLog1.WriteEntry("Demo service started");

            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 60000;
            timer.Elapsed += new System.Timers.ElapsedEventHandler(this.OnTimer);            //callback function
            timer.Start();
        }

        private void OnTimer(object sender, System.Timers.ElapsedEventArgs e)                //essential params for callback function
        {
            eventLog1.WriteEntry("Monitoring the system", EventLogEntryType.Information);
        }

        protected override void OnStop()
        {
            eventLog1.WriteEntry("Demo service stopped");
        }
        
    }
}
