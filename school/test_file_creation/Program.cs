using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace test_file_creation
{
    internal class Program
    {
        private static void AddText(FileStream fs, string value)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(value);
            fs.Write(info, 0, info.Length);
        }
        static void Main(string[] args)
        {
            FileStream file = new FileStream(@"c:\xampp\htdocs\c_sharp\school\test_file_creation\asd.txt", FileMode.OpenOrCreate);
            AddText(file, "asd");
            int a;
            int b = 1;
            int c = 2;
            int e = 230948;
            Console.WriteLine(GC.CollectionCount(0));
            GC.Collect(0);
            GC.Collect(0);
            GC.Collect(0);
            GC.Collect(0);
            Console.WriteLine(GC.CollectionCount(0));
            file.Close();
            Console.ReadKey();
        }
    }
}
