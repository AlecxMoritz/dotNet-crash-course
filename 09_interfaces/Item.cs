using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_interfaces
{
   

    class Item : IItem
    {
        public string Name { get; set; }
        public int GoldValue { get; set; }
        public string ItemType { get; set; } = "Item";

        public void Sell()
        {
            Console.WriteLine("You sold the {0} for {1}", Name, GoldValue);
        }

        public void Equip()
        {
            Console.WriteLine("Equided {0}", Name);
        }

        public void Unequip()
        {
            Console.WriteLine("Unequiped {0}", Name);
        }
    }
}
