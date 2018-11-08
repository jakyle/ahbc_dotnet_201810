using System;

namespace Ahbc.Class.Fourteen
{
  class Program
  {
    static void Main(string[] args)
    {
      var vampire = new Vampire();
      ITeeth toothyFellow = vampire;
      ILimbs armMonster = vampire;
      IMonster monster = vampire;

      //DriveTheWhip(new FordFocus(), 56);
      //TurnOnTheRadio(new FordFocus());
    }

    public static void DriveTheWhip(IVehicle vehicle, int speed)
    {
      Console.WriteLine($"Driving the vehicle {speed}");
      vehicle.Honk();
    }

    public static void TurnOnTheRadio(IFord ford)
    {
      ford.UseMicrosoftSync();
    }
  }

  public interface IMonster
  {
    void Mash();
  }

  public interface ILimbs
  {
    int NumberOfLimbs { get; set; }
    void Grab();
  }

  public interface ITeeth
  {
    bool IsSharp { get; set; }
    void Chomp();
  }

  public class Ghost : IMonster
  {
    public void Mash()
    {
      // wooooo ghost noises
    }
  }

  public class Frankenstein : ITeeth, ILimbs, IMonster
  {
    public bool IsSharp { get; set; }
    public int NumberOfLimbs { get; set; }

    public void Mash()
    {

    }

    public void Grab()
    {

    }

    public void Chomp()
    {

    }
  }

  public class Vampire : ITeeth, ILimbs, IMonster
  {
    public int NumberOfLimbs { get; set; }
    public bool IsSharp { get; set; }

    public void Chomp()
    {
      // suckin yo bloood muahahahaha
    }

    public void Grab()
    {
      // grab to suck yo blood
    }

    public void Mash()
    {
      // mashin' and floatin' in bat form
    }
  }
}
