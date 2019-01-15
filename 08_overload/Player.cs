using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_overload
{
    public class Player
    {
        public string Username { get; set; }
        public string PlayerName { get; set; }
        public int Health { get; set; } = 50;
        public int Mana { get; set; } = 50;
        public int Stamina { get; set; } = 50;
        public int UnarmedPower { get; set; } = 5;

        public virtual void Attack()
        {
            Console.WriteLine("{0} attacked and did {1} damage!", Username, UnarmedPower);
            Stamina = Stamina - 5;
            Console.WriteLine("Stamina reduced to: {0}", Stamina);
        }
    }
}
