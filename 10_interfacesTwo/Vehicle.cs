using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_interfacesTwo
{
    class Vehicle : IDrivable
    {
        public string Make { get; set; }
        public int Wheels { get; set ; }
        public double Speed { get; set; }

        public Vehicle(string make = "none", int wheels = 0, double speed = 0)
        {
            Make = make;
            Wheels = wheels;
            Speed = speed;
        }


        public void Move()
        {
            Console.WriteLine($"The {Make} moved forward at {Speed} MPH");
        }

        public void Stop()
        {
            Console.WriteLine($"The {Make} stops.");
            Speed = 0;
        }
    }
}
