public class Prompt
{
  // public string _description;
  public List<string> _prompts = new List<string> {
        "Who was the most interesting person I interacted with today?",
        "prompt 2",
        "prompt 3",
        "prompt 4",
        "prompt 5",
    };

  // public Prompt(string description)
  // {
  //   _description = description;
  // }

  public string GeneratePrompt()
  {

    Random random = new Random();
    int randomIndex = random.Next(_prompts.Count);

    string randomElement = _prompts[randomIndex];

    return randomElement;
  }
}

