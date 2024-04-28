using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szyper_2024_04_28
{
    internal class number
    {
        public int? value {get;set;}
        public number(int? value)
        {
            this.value = value;
        }
        ~number()
        {
            Console.WriteLine("Object has been deleted.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            number a = new number(0);
            number b = new number(1);
            number c = new number(2);
            int? d = null;
            int? e = 0;
            int? f = 1;
            a = null;
            Console.WriteLine(GC.GetTotalMemory(true));
            Console.WriteLine(GC.GetGeneration(b));
            Console.WriteLine(GC.GetGeneration(c));
            Console.WriteLine(GC.GetGeneration(e));
            Console.WriteLine(GC.GetGeneration(f));
            GC.Collect(0);
            e = null;
            b = null;
            Console.WriteLine(GC.GetTotalMemory(true));
            Console.WriteLine(GC.GetGeneration(c));
            Console.WriteLine(GC.GetGeneration(f));
            GC.Collect(1);
            f = null;
            c = null;
            Console.WriteLine(GC.GetTotalMemory(true));
            GC.Collect(2);
            Console.WriteLine(GC.GetTotalMemory(true));
            GC.Collect();
            Console.ReadKey();
        }
    }
}
