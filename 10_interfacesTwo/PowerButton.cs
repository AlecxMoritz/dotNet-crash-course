using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_interfacesTwo
{
    class PowerButton : IComand
    {
        IElectronicDevice device;

        public PowerButton(IElectronicDevice device)
        {
            this.device = device;
        }

        public void Excecute()
        {
            device.On();
        }

        public void Undo()
        {
            device.Off();
        }
    }
}
