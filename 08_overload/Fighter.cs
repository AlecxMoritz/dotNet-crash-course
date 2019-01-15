using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_overload
{
    class Fighter : Player
    {

        public int Stamina { get; set; } = 70;
        public int Mana { get; set; } = 30;
        public int StaminaDrain { get; set; }
        public string MeleeWeapon { get; set; }
        public int AttackPower { get; set; }
        public string CombatStyle { get; set; }

        public void recieveBroadsword()
        {
            AttackPower = 10;
            StaminaDrain = 10;
            MeleeWeapon = "BroadSword";
            Console.WriteLine("{0} recieved Broadsword! Attack power is now {1}, stamina will be drain by {2}", Username, AttackPower, StaminaDrain);
        }

        public override void Attack()
        {
            Stamina = Stamina - StaminaDrain;
            Console.WriteLine("{0} attacked with {1}, and dealth {2} damage! Stamina reduce to: {3}", Username, MeleeWeapon, AttackPower, Stamina);
        }
    }
}
