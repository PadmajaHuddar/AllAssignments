using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_DAY11
{
    class UsingForDispose
    {
        public StreamWriter fs { get; set; }
        public TextReader tr { get; set; }
        public void fileIO()
        {
            try
            {
                using (fs = new StreamWriter(@"D:\Assigments\C#\Assignments-DAY11\DemoFile2.txt"))
                ////OurStream = File.CreateText("c:\examples\writer\test.txt");
                {    //OurStream.WriteLine("This is a line of text. Writing to the text file.");
                    fs.WriteLine("This is Console.WriteLine");
                    fs.WriteLine("Thanks for playing!");
                    fs.Flush();
                    fs.Close();
                }
                using (TextReader tr = new StreamReader(new FileStream(@"D:\Assigments\C#\Assignments-DAY11\DemoFile2.txt", FileMode.Open, FileAccess.Read, FileShare.ReadWrite)))
                {
                    string s = "";
                    while ((s = tr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }

                Console.ReadLine();
            }
            finally
            {
                if (tr != null)
                {
                    tr.Dispose();
                    Console.WriteLine("Thanks for playing!");
                }
                if (fs != null)
                {
                    fs.Dispose();
                    Console.WriteLine("Thanks for playing!");
                }
            }
        }
    }
}
