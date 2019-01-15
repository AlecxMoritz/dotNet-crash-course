using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_methods
{
    class Enemy
    {
        public Enemy(int a, string n, int h, int ap)
        {
            this.Age= a;
            this.Name = n;
            this.Health = h;
            this.AttackPower = ap;
        }


        public int Age { get; set; }
        public string Name { get; set; }
        public double Health { get; set; }
        public int AttackPower { get; set; }

        public void greeting()
        {
            Console.WriteLine("I'm {0}, prepare to face me!", this.Name);
        }

        public void attack()
        {
            Console.WriteLine("Incoming strike!!");
            Console.WriteLine("{0} just hit for {1} damage!!", this.Name, this.AttackPower);
        }

        public double checkEnemyHealth()
        {
            return this.Health;
        }
    }
}
