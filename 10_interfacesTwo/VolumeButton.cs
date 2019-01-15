using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_interfacesTwo
{
    class VolumeButton : IComand
    {
        IElectronicDevice device;

        public VolumeButton(IElectronicDevice device)
        {
            this.device = device;
        }

        public void Excecute()
        {
            device.VolumeUp();
        }

        public void Undo()
        {
            device.VolumeDown();
        }
    }
}
