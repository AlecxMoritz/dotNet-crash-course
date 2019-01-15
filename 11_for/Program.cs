using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_for
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] Names = new string[5];

            Names[0] = "Alecx";
            Names[1] = "Autumn";
            Names[2] = "Brittany";
            Names[3] = "Nikaya";
            Names[4] = "Trace";

            foreach(string name in Names)
            {

                Console.WriteLine(name + " is awesome!");
            }

            string MyName = "Alecx";

            int L = 1;

            for(int i = 0; i < MyName.Length; i++ )
            {
               
                Console.WriteLine($"{L}: " + MyName[i]);

                L++;
            }
        }
    }
}
