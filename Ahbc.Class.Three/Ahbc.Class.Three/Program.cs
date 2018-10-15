using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahbc.Class.Three
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Nested Loops
            //for (int i = 0; i < 5; i++)
            //{
            //    // Can access i but not j
            //    if (i % 2 == 0)
            //    {
            //        continue;
            //    }

            //    for (int j = 0; j <= 9; j++)
            //    {
            //        // Can access both
            //        if (j % 2 == 0)
            //        {
            //            continue;
            //        }

            //        Console.WriteLine($"The number is {i}{j}");
            //    }
            //}

            // Joining Strings
            //string first = "Jason";
            //string last = "Robert";

            //Console.WriteLine(first + " " + last);
            //Console.WriteLine(string.Concat(first, " ", last, " is sooooo narly"));
            //Console.WriteLine("{0} {1}", first, last);
            //Console.WriteLine($"{first} {last}");
            //Console.WriteLine(string.Format("{0} {1}", first, last));

            // String Comparison
            //string first = "1sts";
            //string second = "1STS";

            //Console.WriteLine(first == second);
            //Console.WriteLine(first.Equals(second));
            //Console.WriteLine(first.Equals(second, StringComparison.OrdinalIgnoreCase));
            //Console.WriteLine(string.Equals(first, second));
            //Console.WriteLine(second.CompareTo(first));
            //Console.WriteLine(string.Compare(first, second, true));

            // String Functions
            Console.Write("Enter your FULL name: ");
            string fullName = Console.ReadLine();
            string first = fullName.Substring(0, fullName.IndexOf(' '));
            Console.WriteLine(fullName.IndexOf(' '));
            Console.WriteLine(first);

            // 012345678901
            // Jason Robert
            Console.WriteLine(fullName.Substring(fullName.IndexOf(' ') + 1));
            Console.WriteLine(fullName.Substring(fullName.LastIndexOf(' ') + 1));
            Console.WriteLine(fullName.StartsWith(first));
            Console.WriteLine(fullName.Replace("Jason", "Joe").Replace("Robert", "Smith"));
            fullName = fullName.Replace("Jason", "Joe").Replace("Robert", "Smith");
            Console.WriteLine(fullName);

            Console.WriteLine(fullName.Split(' ')[0]);

            Console.ReadKey();
        }
    }
}
