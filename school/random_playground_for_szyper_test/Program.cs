using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random_playground_for_szyper_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = new List<int>();

            ints.Add(1);
            ints.Add(10);
            ints.Add(5);

            Console.WriteLine($"Długość listy: {ints.Count}");

            ints.Add(5);
            ints.Add(1);
            
            Console.WriteLine($"Długość listy: {ints.Count}");
            Dictionary<int, int> asd = new Dictionary<int, int>();
            asd[2] = ints[0];
            asd[3] = ints[1];
            asd[4] = ints[2];
            foreach (int i in ints)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            foreach (KeyValuePair<int,int> asd2 in asd)
            {
                Console.Write(asd2.Key + ", " + asd2.Value+"\n");
            }
            ints.Remove(1);
            foreach (int i in ints)
            {
                Console.Write($"{i} ");
            }
            Console.ReadKey();
        }
    }
}
