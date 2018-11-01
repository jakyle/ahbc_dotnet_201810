using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahbc.Class.Eleven
{
  class Program
  {
    static void Main(string[] args)
    {
      var buick = new Buick("DEF54321");
      buick.Drive();
      buick.Stop();
      buick.EngageHandicapHanger();
      RecordLicensePlate(buick);
      GetMyRange(buick);
      Console.WriteLine(buick.Plate);
      Console.WriteLine("---------------");

      Vehicle vehicle = buick;
      TransportationDevice device = buick;
      var range = device.Range;
      // this won't work - CreatingThisAsAnExample(vehicle);

      var lambo = new Lambo("ABC1234");
      lambo.Drive();
      lambo.Stop();
      RecordLicensePlate(lambo);
      GetMyRange(lambo);
      Console.WriteLine(lambo.Plate);
      Console.WriteLine("---------------");

      Vehicle imposter = new SomeLamboImposter("asdfasdf");
      imposter.Drive(); // SomeLamboImposter.Drive() will be called
      Console.WriteLine("---------------");

      Console.ReadLine();
    }

    public static void RecordLicensePlate(Vehicle vehicle)
    {
      var plate = vehicle.Plate;
      Console.WriteLine($"Record {plate}");
    }

    public static void GetMyRange(TransportationDevice device)
    {
      Console.WriteLine($"Your range is {device.Range}");
    }

    public static void CreatingThisAsAnExample(Buick buick)
    {

    }
  }
}
