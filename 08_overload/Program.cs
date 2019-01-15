using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_overload
{
    class Program
    {
        static void Main(string[] args)
        {
            Player Alecx = new Player();
            Alecx.Username = "techno_zelda";
            
            Alecx.Attack();

            Fighter Deluth = new Fighter();
            Deluth.Username = "deldelB0i";

            Deluth.recieveBroadsword();

            Deluth.Attack();
        }
    }
}
