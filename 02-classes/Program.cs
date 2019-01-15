using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Car AlecxCar = new Car();
            AlecxCar.Make = "Ford";
            AlecxCar.Model = "Escape";
            AlecxCar.Year = 2014;
            AlecxCar.VINNum = 123456789;

            Console.WriteLine("Please log your car. . .");

            Car newCar = new Car();

            Console.WriteLine("what is the make of your car?");
            newCar.Make =  Console.ReadLine();
            Console.WriteLine("Make: " + newCar.Make);

            Console.WriteLine("What is the model of your car?");
            newCar.Model = Console.ReadLine();
            Console.WriteLine("Mode: " + newCar.Model);

            Console.WriteLine("What is the year of your car?");
            newCar.Year  = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Year: " + newCar.Year);

            Console.WriteLine("What is the VIN of your car?");
            newCar.VINNum = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Year: " + newCar.VINNum);

            Console.WriteLine("Thank you! We saved you car.");

            Console.WriteLine("You drive a {2} {0} {1}, with VIN number of {3}", newCar.Make, newCar.Model, newCar.Year, newCar.VINNum);

            foreach (var prop in newCar.GetType().GetProperties())
            {
                Console.WriteLine("{0} = {1}", prop.Name, prop.GetValue(newCar, null));
            }
        }
    }
}
