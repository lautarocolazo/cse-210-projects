class Activity
{
  protected string _activity;
  protected string _description;
  protected int _duration;
  protected List<string> _spinnerChars = new List<string> {"|", "/", "-", "\\", "|", "/", "-", "\\"};

  public Activity(string activity, string description, int duration)
  {
    _activity = activity;
    _description = description;
    _duration = duration;
  }

  public void DisplayStartingMessage()
  {
    Console.WriteLine($"Welcome to the {_activity}");

    Console.WriteLine($"{_description}");
    
  }

  public void DisplayEndingMessage()
  {
    Console.WriteLine("Well done!!");

    PauseWhileSpinner();

    if (_duration > 0)
    {
      Console.WriteLine(Environment.NewLine + $"You have completed another {_duration} seconds of the {_activity}");
      PauseWhileSpinner();
    }

    Console.Clear();

  }
  
  public void PauseWhileSpinner()
  {
    foreach (string s in _spinnerChars)
    {
      Console.Write(s);
      Thread.Sleep(300);
      Console.Write("\b \b");
    }
  }

  public void PauseWhileTimer()
  {
    Console.WriteLine("PauseWhileTimer method");
  }

  public void Display()
  {

  }
}
