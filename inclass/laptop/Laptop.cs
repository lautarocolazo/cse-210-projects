public class Laptop
{
  private double _screenSize;
  private string _os;
  private bool _touchScreen;

  public Laptop(double screenSize, string os, bool touchScreen)
  {
    _screenSize = screenSize;
    _os = os;
    _touchScreen = touchScreen;
  }

  public void ShowDetails()
  {
    Console.WriteLine($"{_screenSize} {_os} {_touchScreen}");
  }

}
