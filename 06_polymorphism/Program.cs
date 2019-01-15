using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[3];

            cars[0] = new Car();
            cars[0].Make = "Ford";
            cars[0].Model = "Escape";

            cars[1] = new TwoDoorCar();
            cars[1].Make = "Lamborghini";
            cars[1].Model = "Muira";


            cars[2] = new FourDoorCar();
            cars[2].Make = "GMC";
            cars[2].Model = "Suburban";


            foreach(Car car in cars)
            {
                car.CarFacts();
            }
        }
    }
}
