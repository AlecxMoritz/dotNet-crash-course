using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Names = new List<string>();

            Names.Add("Alecx");
            Names.Add("Autumn");
            Names.Add("Brittany");
            Names.Add("Nikaya");

            foreach(string Name in Names)
            {
                Console.WriteLine(Name);
            }

            Names.Add("Jarred");

            // wait nvm
            Names.Remove("Jarred");

            Console.WriteLine(string.Join(", ", Names));
            Console.WriteLine(Names.Count);
            Console.WriteLine(Names.Capacity);
            Names.Add("Trace");
            Console.WriteLine(Names.Capacity);


            Console.WriteLine("Is alecx here? {0}", Names.Contains("Alecx"));
            Console.WriteLine("Is tom here? {0}", Names.Contains("Tom"));
        }
    }
}
