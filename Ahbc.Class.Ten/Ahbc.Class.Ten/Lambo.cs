using System;

namespace Ahbc.Class.Ten
{
    public class Lambo : Vehicle
    {
        public Lambo(string plate) : base(plate)
        {
            Console.WriteLine("Lambo created!");
            SpeedMph = 200;
        }
    }
}
