using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ahbc.Class.Seven
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring and Instantiating Separately
            int[] intArray1;
            intArray1 = new int[3];

            // Declare, instantiate, and populate
            //var stringArray = new string[3] {"Jason", "Timothy", "Robert"};
            //var stringArray = new string[] {"Jason", "Timothy", "Robert"};
            var stringArray = new[] { "Jason", "Timothy", "Robert" };
            Console.WriteLine(stringArray.Length);
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine($"{i} - {stringArray[i]}");
            }

            //// Arrays of any type
            //string[] stringArray;
            //Regex[] regexArray;

            // Declare and instantiating together
            int[] intArray2 = new int[3];

            // You bet your butt you can use var!
            var intArray3 = new int[3];
            
            // Using a variable to specify length
            int length = 5;
            var dynamicArray = new int[length];

            /////////////////////////////////////////////////////////////////

            // Setting and retrieving array values
            intArray1[0] = 100;
            intArray1[1] = 200;
            intArray1[2] = 300;
            //intArray1[3] = 211;
            //Console.WriteLine(intArray1[0]);

            // Looping through an array with for
            for (int i = 0; i < intArray1.Length; i++)
            {
                Console.WriteLine(intArray1[i]);
            }

            // Looping through an array with foreach
            foreach (var item in intArray1)
            {
                Console.WriteLine(item);
            }
            //// This is the equivalent
            //for (int i = 0; i < intArray1.Length; i++)
            //{
            //    var item = intArray1[i];
            //    Console.WriteLine(item);
            //}

            /////////////////////////////////////////////////////////

            var intArray4 = new[] {1, 2, 3, 4};
            var intArray5 = intArray4;

            intArray5[0] = 9;
            intArray4[0] = 7;
            
            Console.WriteLine(intArray5[0]);

            // parameter by reference
            var superArray = new int[] {4, 5, 6};
            Change(superArray);
            Console.WriteLine(superArray[1]);

            // Copy Function
            var intArray6 = new int[] { 4, 5, 6 };
            int[] intArray7 = new int[10];
            intArray6.CopyTo(intArray7, 0);

            intArray6[0] = 999999090;

            foreach (var item in intArray7)
            {
                Console.Write($"{item}\t");
            }
            
            // Rectangular Array
            // new int[rows, col]
            var intArray8 = new int[4, 3];
            intArray8[1, 2] = 5;
            Console.WriteLine();
            for (int i = 0; i < intArray8.GetLength(0); i++)
            {
                for (int j = 0; j < intArray8.GetLength(1); j++)
                {
                    Console.Write($"{intArray8[i, j]}\t");
                }

                Console.WriteLine();
            }

            // Jagged Array
            var intArray9 = new int[4][];
            intArray9[0] = new int[5];
            intArray9[1] = new int[2];
            intArray9[2] = new int[1];
            intArray9[3] = new int[4];

            Console.ReadKey();
        }

        private static void Change(int[] superDuperArray)
        {
            superDuperArray[1] = 1000000000;
        }
    }
}
