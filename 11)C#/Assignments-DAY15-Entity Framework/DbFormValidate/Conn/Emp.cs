using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conn
{
    public class Emp
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Salary { get; set; }
    }
}
