class ReflectingActivity : Activity
{

  public ReflectingActivity(string activity, string description, int duration) : base(activity, description, duration)
  {

  }

  public void RunActivity()
  {
    Console.WriteLine("RunActivity method");
  }
}
