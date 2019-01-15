using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Bear Alecx = new Bear();
            Alecx.HasEatenHoneyToday = true;
            Alecx.SalmonEatenToday = 3;
            Alecx.Habitat = "Mom's Cave";
            Alecx.CanFly = false;
            Alecx.LivesInWater = false;

            Kangaroo Kanga = new Kangaroo();
            Kanga.HasJooeys = true;
            Kanga.Name = "Kanga";
            Kanga.Habitat = "100 Acre Woods";
            Kanga.KickPower = 9001;
            Kanga.CanFly = false;
        }
    }
}
