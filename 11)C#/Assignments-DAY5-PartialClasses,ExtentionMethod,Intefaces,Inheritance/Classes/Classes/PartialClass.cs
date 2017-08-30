using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public partial class PartialClass
    {
        private string Name
        { get; set; }
        public PartialClass(string name)
        {
            this.Name = name;
        }
        public void display()
        {
            Console.Write("Name: {0}", Name);
            Console.Read();
        }
    }
}
