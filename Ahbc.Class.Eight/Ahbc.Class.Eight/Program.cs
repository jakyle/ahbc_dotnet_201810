using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahbc.Class.Eight
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[9];
            // array[0] = "hello";

            // DO NOT USE THIS
            var arrayList = new ArrayList();
            arrayList.Add("hello");
            arrayList.Add(1);

            // Generic List Collection
            List<int> list = new List<int>();
            //list.Add("hello");
            var number = 1;
            list.Add(number);
            list.Add(2);

            Console.WriteLine(list[0]);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            // Generic Dictionary
            var dictionary = new Dictionary<string, string>();
            dictionary.Add("key1", "asdfasdfasdfasdfasdfasd");
            // dictionary.Add("key1", "esgwrt2356h");
            dictionary["key1"] = "Jason";
            //Console.WriteLine(dictionary["key2"]);
            //Console.WriteLine(dictionary["key1"]);

            // Stack and Queue
            var stack = new Stack<string>();
            stack.Push("Jason");
            stack.Push("Robert");
            // stack.Count
            Console.WriteLine(stack.Pop()); // Robert
            Console.WriteLine(stack.Peek());  // Jason
            Console.WriteLine(stack.Pop());  // Jason

            // Queue Generic
            var goodQueue = new Queue<string>();
            goodQueue.Enqueue("John");
            goodQueue.Enqueue("Smith");
            Console.WriteLine(goodQueue.Dequeue());
            Console.WriteLine(goodQueue.Peek());
            Console.WriteLine(goodQueue.Dequeue());
            //Recursion();

            // Queue non Generic - DON'T USE THIS, ALWAYS USE THE GENERIC FORM
            var badQueue = new Queue();
            badQueue.Enqueue("1");
            badQueue.Enqueue(2);

            WriteMe<int>(9, Sport.Football);
            WriteMe<string>("10", Sport.Soccer);

            Console.ReadKey();
        }

        /// <summary>
        /// Generic function to write whatever you want!!!
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <param name="sport"></param>
        /// <returns></returns>
        public static T WriteMe<T>(T value, Sport sport)
        {
            switch (sport)
            {
                case Sport.Football:
                    Console.WriteLine("Best sport!");
                    break;
                case Sport.Basketball:
                    Console.WriteLine("Ok sport!");
                    break;
                case Sport.Soccer:
                    Console.WriteLine("Real Football!");
                    break;
                case Sport.Tennis:
                    Console.WriteLine("Lifetime Sport!");
                    break;
                default:
                    break;
            }

        //    Console.WriteLine(value);
            return value;
        }

        // Without generics we would have to do this...

        //public static void WriteMe(int value)
        //{
        //    Console.WriteLine(value);
        //}

        //public static void WriteMe(string value)
        //{
        //    Console.WriteLine(value);
        //}

        private static int counter = 0;
        public static void Recursion()
        {
            counter++;
            if (counter == 5)
            {
                throw new Exception("Here");
            }
            Recursion();
        }
    }

    public enum Sport
    {
        Football = 0,

        Basketball = 1,

        Soccer = 2,

        Tennis = 4
    }
}
