using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_hashsets
{
    class Program
    {   // hashsets are used for unique data!!!
        static void Main(string[] args)
        {
            HashSet<int> MyHashSet = new HashSet<int>();
            HashSet<int> NewHashSet = new HashSet<int>();
            MyHashSet.Add(1);
            MyHashSet.Add(2);
            MyHashSet.Add(3);
            MyHashSet.Add(4);
            MyHashSet.Add(5);

            MyHashSet.Add(5);

            NewHashSet.Add(4);

            Console.WriteLine(MyHashSet.Count);
            // printed 5 instead of six because i added 5 twice!
            Console.WriteLine("=====================");
            foreach (int i in MyHashSet)
            {
                Console.WriteLine(i);
            }
            // five was only printed once even though I included it twice

            Console.WriteLine("Did i put 5 in here? {0}", MyHashSet.Contains(5));

            int[] HashArry = MyHashSet.ToArray();

            Console.WriteLine(string.Join(", ", MyHashSet));

            Console.WriteLine(MyHashSet.GetType());
            Console.WriteLine(MyHashSet.Overlaps(NewHashSet));
            Console.WriteLine(MyHashSet.Average());
            // string[] CastTest = MyHashSet.Cast<string>();
        }
    }
}
