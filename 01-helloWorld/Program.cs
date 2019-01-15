using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_helloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // delaration
            string helloWorld;
            // initialize
            helloWorld = "hello World";

            Console.WriteLine(helloWorld);

            // declaration    // initialization
            Console.WriteLine("How are you?");
            string question = Console.ReadLine();
            Console.WriteLine(question);
        }
    }
}
