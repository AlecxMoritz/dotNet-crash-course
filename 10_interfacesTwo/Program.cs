using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_interfacesTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle Chevy = new Vehicle("Chevy", 4, 170);

            // checking to see if the object will implement the interface

            if (Chevy is IDrivable)
            {
                Chevy.Move();
                Chevy.Stop();
            }
            else
            {
                Console.WriteLine($"The {0} be driver");
            }


            IElectronicDevice TV = TVRemote.GetDevice();

            PowerButton PowBut = new PowerButton(TV);

            PowBut.Excecute();
            PowBut.Undo();

            PowBut.Excecute();

            VolumeButton VolBut = new VolumeButton(TV);

            VolBut.Excecute();
            VolBut.Undo();

        }
    }
}
