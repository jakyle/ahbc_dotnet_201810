using System;
using System.Collections.Generic;

namespace Ahbc.Class.Fourteen
{
  class Program
  {
    static void Main(string[] args)
    {
      List<int> test = new List<int>();

      var vampire = new Vampire();
      Console.WriteLine("Hey you vampire, what can you do?");
      WhatCanYouDo(vampire);

      Console.WriteLine("-------------------------");

      var ghost = new Ghost();
      Console.WriteLine("Hey you ghost, what can you do?");
      WhatCanYouDo(ghost);

      Console.ReadKey();


      //DriveTheWhip(new FordFocus(), 56);
      //TurnOnTheRadio(new FordFocus());
    }

    public static void WhatCanYouDo(IMonster monster)
    {
      Console.WriteLine("You can MASH!");

      if (monster is ITeeth)
      {
        Console.WriteLine("You can CHOMP!");
      }

      //var limbs = monster as ILimbs;
      //if (limbs != null)
      //{
      //  Console.WriteLine($"You can GRAB with {limbs.NumberOfLimbs} limbs!");
      //}

      if (monster is ILimbs limbs)
      {
        Console.WriteLine($"You can GRAB with {limbs.NumberOfLimbs} limbs!");
      }
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
