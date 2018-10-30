using System;

namespace Ahbc.Class.Ten
{
    public class Buick : Vehicle
    {
        public Buick(string plate) : base(plate)
        {
            Console.WriteLine("Buick created");
            SpeedMph = 40;
        }
    }
}
