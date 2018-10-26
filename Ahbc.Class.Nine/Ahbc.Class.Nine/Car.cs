namespace Ahbc.Class.Nine
{
    public class Car
    {
        private string _vin;

        public void Drive()
        {
            var speed = CalculateSpeed();
            if (speed > 40)
            {
                ShiftGear(Gear.Fourth);
            }
        }

        public void Stop()
        {

        }

        public void Park(Garage garage)
        {

        }

        private int CalculateSpeed()
        {
            return 0;
        }

        private void ShiftGear(Gear gear)
        {

        }
    }
}
