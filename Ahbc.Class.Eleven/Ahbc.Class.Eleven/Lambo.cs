using System;

namespace Ahbc.Class.Eleven
{
  public class Lambo : Vehicle
  {
    public Lambo(string plate) : base(plate)
    {
      Console.WriteLine("Lambo created!");
      SpeedMph = 200;
    }

    public override void Drive()
    {
      Console.WriteLine("I'm doin some lambo things");
      base.Drive();
    }
  }

  public class SomeLamboImposter : Lambo
  {
    public SomeLamboImposter(string plate) : base(plate)
    {
    }

    //// This won't work because Lambo.Drive() is sealed
    public override void Drive()
    {
      Console.WriteLine("Awww I'm not a lambo");
      base.Drive();
    }
  }
}
