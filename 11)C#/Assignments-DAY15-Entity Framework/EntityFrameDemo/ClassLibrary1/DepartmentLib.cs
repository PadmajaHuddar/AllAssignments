using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class DepartmentLib
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string AddURL { get; set; }
    }
}
