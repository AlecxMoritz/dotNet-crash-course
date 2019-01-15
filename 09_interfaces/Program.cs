using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_interfaces
{
    class Program
    {

        static void Main(string[] args)
        {

            Sword GreatSword = new Sword();
            GreatSword.Name = "Great Sword";
            GreatSword.GoldValue = 200;
            GreatSword.Damage = 15;
            
            string[] Inventory = new string[3];

            Inventory[0] = GreatSword.Name;
            Console.WriteLine("Player inventory: " + Inventory[0]);
            GreatSword.Equip();
            GreatSword.SwingSword();
        }
    }
}
