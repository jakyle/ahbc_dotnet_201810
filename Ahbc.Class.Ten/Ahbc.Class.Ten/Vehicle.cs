using System;

namespace Ahbc.Class.Ten
{
    public class Vehicle : TransportationDevice
    {
        public Vehicle(string plate)
        {
            Plate = plate;
            SpeedMph = 1000000000;
            Console.WriteLine("Vehicle created!");
        }

        //// shorthand, prop + TAB TAB
        // public string Plate { get; set; }

        // longhand version, propfull + TAB TAB
        private string _plate;
        public string Plate
        {
            get { return _plate; }
            set { _plate = value; }
        }

        // Long hand functions, better to use properties!
        public string GetPlate()
        {
            return _plate;
        }

        public void SetPlate(string newPlate)
        {
            _plate = newPlate;
        }

        public void Drive()
        {
            // Really cool interesting stuff
            Console.WriteLine($"They see me rollin' at {SpeedMph} miles per hour!");
        }

        public void Stop()
        {
            Console.WriteLine("Stop in the name of loooove... before you break my heart!");
        }
    }

}
