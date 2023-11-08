public class SmartDevice
{
  protected bool _deviceOn;
  protected DateTime _startTime;
  protected TimeSpan _totalTime;
  private string _name;

  public SmartDevice(string name)
  {
      _deviceOn = false;
      _startTime = DateTime.Now;
      _totalTime = TimeSpan.Zero;
      _name = name;
  }

  public void TurnOn()
  {
    _startTime = DateTime.Now;
    _deviceOn = true;
  }

  public void TurnOff()
  {
    DateTime turnOffTime = DateTime.Now;
    _totalTime += (turnOffTime - _startTime);
    _deviceOn = false;
  }

  public void IsOn()
  {
    if (_deviceOn)
    {
        Console.WriteLine($"The device is on");
    }
    else
    {
        Console.WriteLine($"The device is off");
    }
  }

  public void CheckTime()
  {
    Console.WriteLine($"The device was turned on for: {_totalTime} seconds");
  }
}
