using System;
using System.Text.RegularExpressions;

namespace Ahbc.Class.Six
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PotentiallySomethingBad();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Rut roh! Something bad happened! {ex.Message}");
            }
            catch (Exception)
            {
                Console.WriteLine("Unknown Exception!!!");
            }

            Console.Write("Enter a your digits:\t");
            var value = Console.ReadLine();

            // Ours - @"\(?\d{3}\)?(\-|\.)?\d{3}(\-|\.)?\d{4}"
            var regex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            var result = Regex.IsMatch(value, regex);
            Console.WriteLine(result);

            Console.ReadKey();
        }

        public static void PotentiallySomethingBad()
        {
            // throw new Exception("POW!");
            for (int i = 2; i < -1; i--)
            {
                Console.WriteLine(1 / i);
            }
        }
    }
}
