using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemy Billy = new Enemy(13, "Billy the kid", 25, 3);
            Enemy SuperVillan = new Enemy(100, "Xemnas", 50, 25);

            Billy.greeting();
            SuperVillan.greeting();
            SuperVillan.attack();
            Billy.attack();
        }
    }
}
