using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_polymorphism
{
    class TwoDoorCar : Car
    {
        public int Year { get; set; }
        public int Capacity { get; set; }

        public override void CarFacts()
        {
            Console.WriteLine("Well thats a {0} {1}!!!", this.Make, this.Model);
            Console.WriteLine("It's really small!");
        }
    }
}
