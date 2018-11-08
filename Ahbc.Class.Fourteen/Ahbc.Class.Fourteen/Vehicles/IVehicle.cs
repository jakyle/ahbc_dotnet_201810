namespace Ahbc.Class.Fourteen
{
  public interface IVehicle
  {
    void Drive(int speed);

    void Honk();

    int Speed { get; set; }
  }
}
