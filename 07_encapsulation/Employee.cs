using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_encapsulation
{
    class Employee
    {   // this is encapsulation -- hiding the complexity and encapsulating it somewhere to keep the main section/program decluttered




        // notice we're hiding the juicy bits in here
        // instead of putting it in the program file
        // the _ goes in front of 'backing fields'
        private int _employeeId;

        public int EmployeeId
        {
            get { return _employeeId; }

            // a setter is a void function
            set {
                if(value <= 0)
                {
                    throw new Exception("Bruh, it can't be less than one.");
                }
                _employeeId = value;
            }
        }

        private int _yearsExperiance;

        public int YearsExperiance
        {
            get { return _yearsExperiance; }
            set {
                if(value <= 0)
                {
                    throw new Exception("Bruh, it still can't be less than one!");
                }
                _yearsExperiance = value;
            }
        }

    }
}
