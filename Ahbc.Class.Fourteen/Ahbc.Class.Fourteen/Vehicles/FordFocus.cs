namespace Ahbc.Class.Fourteen
{
  public class FordFocus : Car, IFord
  {
    public int Speed { get; set; }

    public void Drive(int speed)
    {
      Speed = speed;
    }

    public void Honk()
    {
      // Honk Honk
    }

    public override void Release()
    {
      // The Kracken!!!
    }

    public void UseMicrosoftSync()
    {
      // Activate Synce
    }


  }
}
