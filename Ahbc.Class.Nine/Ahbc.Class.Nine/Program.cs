using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahbc.Class.Nine
{
    class Program
    {
        static void Main(string[] args)
        {
            var myOldHome = new Garage(3115, "N. Buttons");
            Console.WriteLine(myOldHome.GetAddress());

            var defaultHome = new Garage();
            Console.WriteLine(defaultHome.GetAddress());

            var someCar = new Car();
            someCar.Drive();
            someCar.Stop();
            someCar.Park(myOldHome);
            
            var someOtherCar = new Car();
            someOtherCar.Drive();

            Console.ReadKey();
        }
    }
}
