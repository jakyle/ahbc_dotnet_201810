using System;

namespace Ahbc.Class.Ten
{
    class Program
    {
        static void Main(string[] args)
        {
            //var vehicle1 = new Vehicle("ABC12345");
            //var plate = vehicle1.GetPlate();
            //var samplePlate = vehicle1.Plate;

            var buick = new Buick("DEF54321");
            buick.Drive();
            buick.Stop();
            Console.WriteLine(buick.Plate);

            var buick1 = new Buick("SL0W");
            buick1.Drive();
            buick1.Stop();
            Console.WriteLine(buick1.Plate);

            var lambo = new Lambo("Fa5T");
            lambo.Drive();
            lambo.Stop();
            Console.WriteLine(lambo.Plate);

            Console.ReadKey();
        }
    }
}
