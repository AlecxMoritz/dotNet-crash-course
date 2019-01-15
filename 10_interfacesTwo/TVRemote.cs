using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_interfacesTwo
{
    class TVRemote
    {
        public static IElectronicDevice GetDevice()
        {
            return new Television();
        }
    }
}
