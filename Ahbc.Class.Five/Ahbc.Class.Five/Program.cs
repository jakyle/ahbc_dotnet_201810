using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahbc.Class.Five
{
    public class Program
    {
        // Entry point of the application
        public static void Main(string[] args)
        {
            //SayHello();
            //SayHello("Jason");

            //// Pass by value
            //int i1 = 0;
            //UpdateNumber1(i1);
            //Console.WriteLine($"Main i1 (passed by value) - {i1}");
            //Console.WriteLine();

            //// Pass by reference
            //int i2 = 0;
            //UpdateNumber2(ref i2);
            //Console.WriteLine($"Main i2 (passed by ref) - {i2}");
            //Console.WriteLine();

            //// var... is magic... literally, like unicorn magic
            //int one = 1;
            //var two = 2;

            //string jason = "jason";
            //var robert = "robert";

            //// Out Parameters
            //Console.WriteLine("Enter a number.  DONT YOU DARE TRY ANYTHING ELSE!");
            //string number = Console.ReadLine();
            ////var value = 234;
            ////var result = int.TryParse(number, out value);
            //var result = int.TryParse(number, out int value);
            //Console.WriteLine($"{result},{value}");

            Console.WriteLine("Enter a short string or a long string...");
            var value = Console.ReadLine();
            var result = TryGetShortLength(value, out int length);
            Console.WriteLine($"{result},{length}");

            Console.ReadKey();
        }

        
        // function with no parameters and no return type
        public static void SayHello()
        {
            Console.WriteLine("What is your name sire?");
            string name = Console.ReadLine();

            string message = $"Hello {name}!";
            Console.WriteLine(message);
        }

        // Overloading SayHello() with addt parameter
        public static void SayHello(string name)
        {
            Console.WriteLine("Yahtzee");
        }
        
        public static void UpdateNumber1(int value)
        {
            Console.WriteLine($"UpdateNumber1 value (passed by value) - {value}");
            value += 1;
            value++;
            value = value + 1;
            Console.WriteLine($"UpdateNumber1 value (passed by value) - {value}");
        }

        public static void UpdateNumber2(ref int value)
        {
            Console.WriteLine($"UpdateNumber2 value (passed by ref) - {value}");
            value += 1;
            value++;
            value = value + 1;
            Console.WriteLine($"UpdateNumber2 value (passed by ref) - {value}");
        }

        public static bool TryGetShortLength(string value, out int length)
        {
            var valueLength = value.Length;
            if (valueLength > 10)
            { 
                length = 0;
                return false;
            }

            length = valueLength;
            return true;
        }
    }
}
