using System;

namespace Ahbc.Class.Eleven
{
  public class Buick : Vehicle
  {
    public Buick(string plate) : base(plate)
    {
      Console.WriteLine("Buick created");
      SpeedMph = 40;
    }

    public void EngageHandicapHanger()
    {

    }
  }

  public class SomeImposterBuick : Buick
  {
    public SomeImposterBuick(string plate) : base(plate)
    {
    }

    public override void Drive()
    {
      base.Drive();
    }
  }
}
