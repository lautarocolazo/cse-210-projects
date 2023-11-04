class ListingActivity : Activity
{

  List<string> _prompts = new List<string> {
    "Listing activity prompt 1.",
    "Listing activity prompt 2.",
    "Listing activity prompt 3.",
  };

  List<string> _responses = new List<string>();

  public ListingActivity(string activity, string description, int duration) : base(activity, description, duration)
  {

  }

  public void RunActivity()
  {
    Random random = new Random();
    int randomIndex = random.Next(_prompts.Count);
    string randomElement = _prompts[randomIndex];

    Console.WriteLine("List as many responses you can to the following prompt:");
    Console.WriteLine($"---- {randomElement} ----");

    Console.Write("You may begin in: ");
    for (int j = 5; j > 0; j--)
    {
      Console.Write(j);
      Thread.Sleep(1000);
      Console.Write("\b \b");
    }

    Console.Clear();

    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(_duration);

    while (DateTime.Now < endTime)
    {
      Console.Write(Environment.NewLine + $"> ");
      string response = Console.ReadLine();

      _responses.Add(response);
    }

    Console.WriteLine($"You listed {_responses.Count} items!");
    Console.WriteLine();
    Console.WriteLine();

  }
}
