using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;


namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream f1 = new FileStream("C:/Users/Ученик/Desktop/F/1.txt", FileMode.OpenOrCreate);
            StreamReader reader = new StreamReader(f1);
            StreamWriter writer = new StreamWriter(f1);
            Console.WriteLine(reader.ReadToEnd());
            Console.ReadKey();
            writer.WriteLine("LOLICON");
            //writer.Close();
            //f1.Seek(1,SeekOrigin.Begin);
            string alpha = reader.ReadToEnd();
            Console.WriteLine(alpha);
            Console.ReadKey();
            f1.Close();
            reader.Close();
        }
    }
}
