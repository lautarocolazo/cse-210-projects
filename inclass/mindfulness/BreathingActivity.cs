class BreathingActivity : Activity
{

  public BreathingActivity(string activity, string description, int duration) : base(activity, description, duration)
  {

  }

  public void RunActivity()
  {
    Console.WriteLine("RunActivity method");
  }
}
