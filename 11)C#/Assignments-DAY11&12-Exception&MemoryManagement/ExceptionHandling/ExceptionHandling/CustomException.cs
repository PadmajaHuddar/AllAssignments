using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class NewException : Exception
    {
        public NewException(string message):base (message)
        { }
    }
    class CustomException
    {
    }
}
