using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_interfaces
{
    class Sword : Item , IItem
    {
        public new string ItemType { get; set; } = "Sword";
        public int Damage { get; set; }

        public void SwingSword()
        {
            Console.WriteLine("Swung {0}, dealt {1} damage.", Name, Damage);
        }
    }
}
