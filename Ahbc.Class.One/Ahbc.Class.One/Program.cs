using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahbc.Class.One
{
    class Program
    {
        /// <summary>
        /// My main method that will show when referenced
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const string WelcomeText = "Hi.  Whats your name?";

            // Asking for name
            Console.WriteLine(WelcomeText);
            string name = Console.ReadLine();

            /* Writing 
             * Name */
            Console.WriteLine(name);
            Console.ReadKey();
        }
    }
}
