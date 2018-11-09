namespace Ahbc.Class.Fourteen
{
  public abstract class Car
  {
    public virtual void DriveFast()
    {
      // They see me roooolllin'
      Release();
    }

    public abstract void Release();
  }
}
