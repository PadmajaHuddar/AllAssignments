using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_DAY11
{
    class ImplIDisposable : IDisposable
    {
        public StreamWriter writer { get; set; }
        public StreamReader reader { get; set; }
        public void fileIO()
        {
            writer = new StreamWriter(new FileStream(@"D:\Assigments\C#\Assignments-DAY11\DemoFile.txt", FileMode.OpenOrCreate));
            ////OurStream = File.CreateText("c:\examples\writer\test.txt");
            //OurStream.WriteLine("This is a line of text. Writing to the text file.");
            writer.WriteLine("This is Console.WriteLine");
            writer.WriteLine("Thanks for playing!");
            writer.Flush();
            writer.Close();

            reader = new StreamReader(@"D:\Assigments\C#\Assignments-DAY11\DemoFile.txt");
            Console.WriteLine(reader.ReadToEnd());

            //using (StreamReader sr = File.OpenText(fileName))
            //{
            //    string s = "";
            //    while ((s = sr.ReadLine()) != null)
            //    {
            //        Console.WriteLine(s);
            //    }
            //}
            Console.ReadLine();
        }
        
        public void Dispose()
        {
            Dispose(true);
        }
        private void Dispose(bool disposing)
        {
            if(disposing)
            {
                GC.SuppressFinalize(this);
            }
            if(writer!=null)
            {
                writer.Dispose();
                Console.WriteLine("Thanks for playing!");
            }
                    
        }
            
    }
}
