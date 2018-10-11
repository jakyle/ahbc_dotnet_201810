using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahbc.Class.Two
{
    class Program
    {
        static void Main(string[] args)
        {
            int collegeNumber = 56;

            Console.WriteLine("College Number = " + collegeNumber);
            Console.WriteLine("High School Number = " + collegeNumber++);
            Console.WriteLine("High school number again = " + collegeNumber);

            /* This is because collegeNumber++ is the same as 
             * collegeNumber = collegeNumber + 1
            */

            int highSchoolNumber = 57;
            Console.WriteLine("High School Number = " + highSchoolNumber);
            highSchoolNumber += 3;
            Console.WriteLine($"Never my number = {highSchoolNumber}");
            /* This is because highSchoolNumber += 3 is the same as
             * highSchoolNumber = highSchoolNumber + 3
             */

            // implicit cast
            int someInt = 2;
            long someLong = someInt;

            // explicit cast
            long smallLongNumber = 1;
            int smallNumber = (int)smallLongNumber;

            // Comparison operators
            Console.WriteLine(someInt == smallLongNumber);
            Console.WriteLine(someInt != smallLongNumber);
            Console.WriteLine(someInt > smallLongNumber);

            // Logical operators
            Console.WriteLine(someInt == smallLongNumber && someInt > smallLongNumber);

            // If Statement
            Console.Write("Enter your name brosef: ");
            string input = Console.ReadLine();
            if (input == "Jason")
            {
                Console.WriteLine("Cool First Name Dude!");
            }
            else
            {
                Console.WriteLine("I don't know you, fool!");
            }

            // Switch Statement
            Console.Write("How was your day dude: ");
            input = Console.ReadLine();
            switch (input)
            {
                case "good":
                    Console.WriteLine("Awesome, I'm so happy for you. dude");
                    break;
                case "bad":
                    Console.WriteLine("Sorry bro!");
                    break;
                default:
                    Console.WriteLine("Ok, I guess");
                    break;
            }

            // Ternary Operator - Short hand if / else
            Console.WriteLine("again.. What is your name!...");
            string name = Console.ReadLine();
            string message = name == "James"
                ? "Sup James!"
                : "You are not James...";
            Console.WriteLine(message);

            // String interpolation
            int x = 3;
            string myName = "jason";
            Console.WriteLine($"{myName} is {x + 1} times cooler than anyone else I know");

            // While loop
            int whileNumber = 0;
            while (whileNumber < 6)
            {
                Console.Write($"{whileNumber} ");
                whileNumber++;
            }

            // Do Loop
            int number = 7_000_000;
            do
            {
                Console.Write($"{number} ");
                number++; // number = number + 1, number += 1
            } while (number < 6);

            Console.WriteLine(number);

            // For loop
            for (int j = 1; j < 6; j += 2)
            {
                Console.WriteLine(j);
            }

            int number1 = 1;
            while (number1 < 5)
            {
                Console.WriteLine(number1);
                if (number1 % 2 == 0)
                {
                    break;
                }
                number1++;
            }

            int k = 2;
            while (k < 10)
            {
                k++;

                if (k % 2 == 0)
                {
                    continue;
                }

                Console.WriteLine(k);
            }

            Console.ReadKey();
        }
    }
}
