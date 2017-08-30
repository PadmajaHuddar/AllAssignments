using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public partial class PartialClass
    {
        public int num;
        public string name;
        public PartialClass(int no, string nm)
        {
            this.num = no;
            this.name = nm;
        }
        public void displayDetails()            //cannot use same method name
        {
            Console.WriteLine("No:{0}", num);
            Console.Write("Name: {0}", name);
            Console.Read();
        }
    }
}

/*partial class used for two developers to work on same class differently; classes not merged in the end but compiler treats both 
  class as the same. Used for aspx example (does design and coding together)*/
