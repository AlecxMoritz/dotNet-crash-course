using System;
using System.Collections; // lets us use lists
using System.Collections.Generic; // lets us use dictionaries
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_collections
{
    class Program
    {
        static void Main(string[] args)
        {

            // Array List Code
            Console.WriteLine("ARRAY LISSSSTS");
            #region

            ArrayList AList = new ArrayList();

            AList.Add("Alecx");
            AList.Add(50);
            AList.Add("hello");

            Console.WriteLine("Count: {0}", AList.Count);


            // capacity will increase by 2 whenever you add an item
            Console.WriteLine("Capacity: {0}", AList.Capacity);

            ArrayList AListTwo = new ArrayList();

            AListTwo.AddRange(new object[] { "Alecx", "Mike", "Egg", "Sally" });

            Console.WriteLine("Adding list two to list one");
            AList.AddRange(AListTwo);
            Console.WriteLine("Count: {0}", AList.Count);

            // more things you can do with array lists

            AListTwo.Sort();
            AListTwo.Reverse();

            AListTwo.Insert(1, "Thelma");

            // making a new array list using items from another

            ArrayList Range = AListTwo.GetRange(0, 2);

            foreach(object item in Range)
            {
                Console.WriteLine(item);
            }

            // how to remove items

            // at a specified index
            // Range.RemoveAt(0);

            // removed a range of items from a specified starting place, and a 'how many?' parameter
            // Range.RemoveRange(0, 2);


            // searching!!

            Console.WriteLine("Index of Alecx: {0}", AListTwo.IndexOf("Alecx", 0));

            // convert an array list into a string array

            string[] myArray = (string[])AListTwo.ToArray(typeof(string));

            string[] Customers = { "Bob", "Jim", "Kim", "Timothy" };

            ArrayList CustomerArrayList = new ArrayList();

            CustomerArrayList.AddRange(Customers);

            foreach(string customer in CustomerArrayList)
            {
                Console.WriteLine(customer);
            }

            #endregion
            Console.WriteLine("DICTIONARIESSSSSSS");
            #region

            Dictionary<string, string> Heroes = new Dictionary<string, string>();

            Heroes.Add("Clark Kent", "Superman");
            Heroes.Add("Dick Clark", "Robin");
            Heroes.Add("Bruce Wayne", "Batman");
            Heroes.Add("Peter Parker", "Spiderman");
            Heroes.Add("Barry West", "The Flash");


            // robin is a side kick, bye bye dick
            Heroes.Remove("Dick Clark");

            Console.WriteLine("Count: {0}", Heroes.Count);

            // finding out if an item is within the dictionary
            Console.WriteLine("Clark Kent? {0}", Heroes.ContainsKey("Clark Kent"));

            // get value for key and store in string

            Heroes.TryGetValue("Clark Kent", out string Test);

            Console.WriteLine($"Who is Clark Kent really? {Test} of course");

            // iterate through dictionary

            foreach(KeyValuePair<string, string> hero in Heroes)
            {
                Console.WriteLine("{0} : {1}", hero.Key, hero.Value);
            }

            // cls an entire dicionary with ease!!!
            Heroes.Clear();
            // this removed and deletes EVERYTHING so be wary
            #endregion
            Console.WriteLine("QUEUESSSSS because ya gotta love 'em");
            #region
            Queue MyQueue = new Queue();

            // add items to queues with 'enqueue'

            MyQueue.Enqueue(3);
            MyQueue.Enqueue(1);
            MyQueue.Enqueue(2);

            foreach(object item in MyQueue)
            {
                Console.WriteLine(item);
            }

            // is this in my queue?

            Console.WriteLine("is 1 in queue? {0}",MyQueue.Contains(1));

            // removing items from the queue cannot be done off of the index, but dequeue will remove AND return the first value in the queue
            Console.WriteLine("Remove three! {0}", MyQueue.Dequeue());

            foreach (object item in MyQueue)
            {
                Console.WriteLine(item);
            }

            // you can use peek to look at, but not remove the first item
            Console.WriteLine("Peaking at one: {0}", MyQueue.Peek());

            // turn an array into a queue

            object[] NumArray = MyQueue.ToArray();

            Console.WriteLine(string.Join(", ", NumArray));

            // you can clear these like dictionaries too!
            // MyQueue.Clear()



            #endregion
            Console.WriteLine("Stacky STACKS");
            #region

            Stack MyStack = new Stack();

            // push items into the stack

            MyStack.Push(1);
            MyStack.Push(2);
            MyStack.Push(3);
            MyStack.Push(4);

            foreach(object item in MyStack)
            {
                Console.WriteLine(item);
            }

            // peeking at the first item
            Console.WriteLine("Peekin: {0}", MyStack.Peek());

            // remove items with a 'pop'
            Console.WriteLine("Remove four! {0}", MyStack.Pop());

            foreach (object item in MyStack)
            {
                Console.WriteLine(item);
            }

            // contains 
            Console.WriteLine("Is one in the stack? {0}", MyStack.Contains(1));

            //copy stack to an array!

            object[] StackArray = MyStack.ToArray();

            Console.WriteLine(string.Join(",", StackArray));

            // clearing works just like the others
            // MyStack.Clear();


            #endregion


        }
    }
}
