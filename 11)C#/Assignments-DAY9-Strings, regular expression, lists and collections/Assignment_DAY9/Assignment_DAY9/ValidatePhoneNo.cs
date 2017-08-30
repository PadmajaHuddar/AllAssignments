using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment_DAY9
{
    class ValidatePhoneNo
    {
        public void PhoneNo(string number)
        {
            string pattern = @"^\d{3}-\d{4}$";
            Regex r = new Regex(pattern, RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace);
            Match m = r.Match(number);
            if (m.Success)
            {
                Console.WriteLine("Valid phone number");
            }
            else
            {
                Console.WriteLine("Not valid");
            }

        }
    }
}
