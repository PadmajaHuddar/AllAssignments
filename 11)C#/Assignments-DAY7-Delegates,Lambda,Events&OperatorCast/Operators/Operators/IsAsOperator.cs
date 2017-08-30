using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class IsAsOperator
    { 
       
        public void IsOpr()
        {
            int a = 200000;
            //int b = 300000;
            Console.WriteLine("Size of : {0}", sizeof(float));          //sizeof operator
            Console.WriteLine("Type of : {0}", typeof(C1));             //used in case of reflextion
            if(a is int)               //is returns only boolean
            {
                Console.Write("a is an integer");
            }
            else
            {
                Console.Write("Not an integer");
            }
            Console.Read();
        }
    }
    class C1
    {

    }
    class C2
    {

    }
    class AsOpr
    {
        public void display()
        {
            Console.WriteLine("In method display");
        }
        public void asOpr()
        {
            object[] myObjects = new object[6];
            myObjects[0] = new C1();
            myObjects[1] = new C2();
            myObjects[2] = "string";
            myObjects[3] = 32;
            myObjects[4] = null;
            for(int i=0;i<myObjects.Length;++i)
            {
                string s = myObjects[i] as string;               //as compares and provides back the value as well
                //int? val = myObjects[i] as int?;
                Console.WriteLine("{0}:", i);
                if (s != null)
                    Console.WriteLine("'" + s + "'");
                else
                    Console.WriteLine("not a string");
            }
            Console.Read();
        }
    }
}
