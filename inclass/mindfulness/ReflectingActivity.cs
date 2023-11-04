class ReflectingActivity : Activity
{
  Dictionary<string, List<string>> _prompts = new Dictionary<string, List<string>>
  {
    {"Prompt 1.", new List<string> {"Question 1 prompt 1", "Question 2 prompt1"}},
    {"Prompt 2.", new List<string> {"Question 2 prompt 1", "Question 2 prompt2"}},
    {"Prompt 3.", new List<string> {"Question 3 prompt 1", "Question 2 prompt3"}}, 
  };
  // List<string> _prompts = new List<string> {
  //   "Prompt 1.",
  //   "Prompt 2.",
  //   "Prompt 3."
  // };

  public ReflectingActivity(string activity, string description, int duration) : base(activity, description, duration)
  {

  }

  public void RunActivity()
  {
    Random random = new Random();
    int randomIndex = random.Next(_prompts.Keys.Count);
    string randomElement = _prompts.Keys.ElementAt(randomIndex);

    Console.WriteLine("Consider the following prompt:");
    Console.WriteLine($"---- {randomElement} ----");

    Console.Write("When you have something in mind, press enter to continue.");
    Console.ReadLine();

    Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");

    Console.Write("You may begin in: ");
    for (int j = 5; j > 0; j--)
    {
      Console.Write(j);
      Thread.Sleep(1000);
      Console.Write("\b \b");
    }

    Console.Clear();
    
    List<string> selectedPromptQuestions = _prompts[randomElement];

    if (selectedPromptQuestions != null && selectedPromptQuestions.Count > 0)
    {
      float timeQuestion = _duration / selectedPromptQuestions.Count;

      DateTime startTime = DateTime.Now;
      DateTime endTime = startTime.AddSeconds(_duration);

      while (DateTime.Now < endTime)
      {
        int randomIndexQuestion =  random.Next(selectedPromptQuestions.Count);
        string randomSelectedQuestion = selectedPromptQuestions[randomIndexQuestion];

        Console.Write(Environment.NewLine + $"> {randomSelectedQuestion} ");
        PauseWhileSpinner();
      }
      Console.WriteLine();
      Console.WriteLine();
    }
  }
}
