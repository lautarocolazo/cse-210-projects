class Activity
{
  protected string _activity;
  protected string _description;
  protected string _duration;

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

    if (_duration)
    {
      Console.WriteLine($"You have completed another {_duration} seconds of the {_activity}");
    }

  }
  
  public void PauseWhileSpinner()
  {
    Console.WriteLine("PauseWhileSpinner method");
  }

  public void PauseWhileTimer()
  {
    Console.WriteLine("PauseWhileTimer method");
  }

  public void Display()
  {

  }
}
