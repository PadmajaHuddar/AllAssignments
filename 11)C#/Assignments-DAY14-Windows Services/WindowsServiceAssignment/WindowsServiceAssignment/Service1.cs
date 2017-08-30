using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WindowsServiceAssignment
{
    public partial class ServiceAssignment : ServiceBase
    {
        static string oldDir = @"C:\\New Folder";
        static string newDir = @"C:\\New Folder 2";
        public ServiceAssignment()
        {
            InitializeComponent();
            if (!System.Diagnostics.EventLog.SourceExists("ServiceAssignmentSource"))
                System.Diagnostics.EventLog.CreateEventSource("ServiceAssignmentSource", "ServiceAssignmentLog");

            eventLog1.Source = "ServiceAssignmentSource";
            eventLog1.Log = "ServiceAssignmentLog";

            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = oldDir;

            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            watcher.Filter = "*.*";

            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.Deleted += new FileSystemEventHandler(OnChanged);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);
            watcher.EnableRaisingEvents = true;

        }

        private void OnChanged(object source, FileSystemEventArgs e)
        {
            File.Copy(oldDir + e.Name, newDir + e.Name, true);
            eventLog1.WriteEntry(string.Format("File:{0} is {1}", e.FullPath, e.ChangeType));
        }

        private void OnRenamed(object source, RenamedEventArgs e)
        {
            eventLog1.WriteEntry(string.Format("File: {0} renamed to {1}", e.OldFullPath, e.FullPath));
        }

        protected override void OnStart(string[] args)
        {
            eventLog1.WriteEntry("Assignment service started");
        }

        protected override void OnStop()
        {
            eventLog1.WriteEntry("Assignment service stopped");
        }

        protected override void OnPause()
        {
            eventLog1.WriteEntry("Assignment service paused");
        }

        protected override void OnContinue()
        {
            eventLog1.WriteEntry("Assignment service continued");
        }
    }
}
