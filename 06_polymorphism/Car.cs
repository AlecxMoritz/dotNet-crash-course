using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_polymorphism
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }

        public virtual void CarFacts()
        {
            Console.WriteLine("Well thats a {0} {1}!!!", this.Make, this.Model);
        }

    }
}
