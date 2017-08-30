using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_DAY9
{
    class HashTAbleExample
    {
        public void HashExample()
        {
            Hashtable ht = new Hashtable();

            ht.Add("001", "Zara Chris");
            ht.Add("002", "Abida Rehman");
            ht.Add("003", "Joe Holzner");
            ht.Add("004", "Mausam Benazir Nur");
            ht.Add("005", "M. Fhone");
            ht.Add("006", "M. Jio");
            ht.Add("007", "Ritesh Saikia");
            ht["in"] = "india";
            ht["en"] = "England";
            ht["us"] = "USA";
            if (ht.ContainsValue("Nuha Ali"))
            {
                Console.WriteLine("This student name is already in the list");
            }
            else
            {
                ht.Add("008", "Nuha Ali");
            }
            
            ICollection key = ht.Keys;

            foreach (string k in key)
            {
                Console.WriteLine(k + ": " + ht[k]);
            }
            ht.Remove("in");
            ht.Remove("003");
                        
            Console.WriteLine("\n\n After removal:");
            foreach (string k in key)
            {
                Console.WriteLine(k + ": " + ht[k]);
            }
            Console.ReadKey();
        }

    }
}
