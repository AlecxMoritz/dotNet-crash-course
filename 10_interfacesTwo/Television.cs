using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_interfacesTwo
{
    class Television : IElectronicDevice
    {
        public int Volume { get; set; }
        public bool IsOn { get; set; }

        public void Off()
        {
            Console.WriteLine("The TV is off");
            IsOn = false;
        }

        public void On()
        {
            Console.WriteLine("The TV is on");
            IsOn = true;
        }

        public void VolumeDown()
        {
            if (IsOn == true)
            {
            if (Volume != 0) Volume--;
            Console.WriteLine($"The TV Volume is at {Volume}");
            } else
            {
                Console.WriteLine("The Tv is still off.");
            }
            

        }

        public void VolumeUp()
        {
            if(IsOn == true)
            {
            if (Volume != 20) Volume++;
            Console.WriteLine($"The TV Volume is at {Volume}");
            } else
            {
                Console.WriteLine("The TV is still off.");
            }


        }
    }
}
