using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_inheritance
{
    public abstract class Animal
    {
        public int Eyes { get; set; }
        public bool LivesInWater { get; set; }
        public string Name { get; set; }
        public double Height { get; set; }
        public bool CanFly { get; set; }
        public string Habitat { get; set; }

    }
}
