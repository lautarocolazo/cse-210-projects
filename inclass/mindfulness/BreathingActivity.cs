class BreathingActivity : Activity
{

  public BreathingActivity(string activity, string description, int duration) : base(activity, description, duration)
  {

  }

  public void RunActivity()
  {
    // int i = 0;

    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(_duration);

    while (DateTime.Now <= endTime)
    {
      Console.WriteLine();
      Console.Write("Breath in...");
      for (int j = 4; j > 0; j--)
      {
        Console.Write(j);
        Thread.Sleep(1000);
        Console.Write("\b \b");
      }

      Console.WriteLine();
      Console.Write("Now breath out...");
      for (int j = 6; j > 0; j--)
      {
        Console.Write(j);
        Thread.Sleep(1000);
        Console.Write("\b \b");
      }

      Console.WriteLine();
      Console.WriteLine();
      // i++;
      //
      // if (i >= _spinnerChars.Count)
      // {
      //   i = 0;
      // }
    }
  }
}
