using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_constructors
{
    class Dog
    {
        public Dog(string b, string n, int a, bool ic)
        {
            this.Breed = b;
            this.Name = n;
            this.Age = a;
            this.IsCute = ic;
        }

        public string Breed { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsCute { get; set; }

        public static void OrderDog()
        {
            Console.WriteLine("So you're looking for a dog?");
            Console.WriteLine("What breed of dog would you like?");
            string newBreed = Console.ReadLine();
            Console.WriteLine("Nice! What do you wanna call them?");
            string newName = Console.ReadLine();
            Console.WriteLine("Got it! About how old are you thinking?");
            int newAge = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Sick! Are the cute? true/false");
            bool newIsCute = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("We've got! Here are your search parameters!");

            Dog newDog = new Dog(newBreed, newName, newAge, newIsCute);
            Console.WriteLine("Breed: " + newDog.Breed);
            Console.WriteLine("Name: " + newDog.Name);
            Console.WriteLine("Age: " + newDog.Age);
            Console.WriteLine("Cute: " + newDog.IsCute);
        }

    }
}
