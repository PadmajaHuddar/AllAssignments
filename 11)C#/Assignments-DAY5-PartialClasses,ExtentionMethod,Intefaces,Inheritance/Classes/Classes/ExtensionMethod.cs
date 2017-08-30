using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public static class ExtensionMethod
    {
        public static string UpperCase(this string sentence)
        {
            sentence=sentence.ToUpper();
            return sentence;
        }
        public static string LowerCase(this string sentence)
        {
            sentence=sentence.ToLower();
            return sentence;
        }
    }
}

//class must be static, method must be static and parameter must have this and the primitive data type for which we want to extend the method
//cann also be used for classes by passing class objs