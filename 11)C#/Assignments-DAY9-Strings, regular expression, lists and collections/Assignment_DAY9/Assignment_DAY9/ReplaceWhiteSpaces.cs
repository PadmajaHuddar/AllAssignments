using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment_DAY9
{
    class ReplaceWhiteSpaces
    {
        public void removeWhiteSpaces(string str)
        {
           Console.WriteLine(Regex.Replace(str, @"\s+", ""));
        }
    }
}
