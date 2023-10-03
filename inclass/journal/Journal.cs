public class Journal
{
  public string _owner;
  public List<Entry> _entries = new List<Entry>();
  public string _description;
  public List<string> prompts = new List<string> {
        "Who was the most interesting person I interacted with today?",
        "prompt 2",
        "prompt 3",
        "prompt 4",
        "prompt 5",
    };

  public Journal(string owner, string description)
  {
    _owner = owner;
    _description = description;
  }

  public void ShowAllEntries()
  {
    Console.WriteLine("Showing entries");
    foreach (Entry entry in _entries)
    {
        entry.DisplayEntry();
    }
  }
  public void DeleteJournal()
  {
    Console.WriteLine("Deleting journal");
  }
  public void ModifyOwner()
  {
    Console.WriteLine("Modifying owner");
  }
  public void ModifyDescription()
  {
    Console.WriteLine("Modifying description");
  }
  public void ShowData()
  {
    Console.WriteLine("Showing journal data");
  }
  public void Save()
  {
    Console.WriteLine("Saving file");
  }
  public void Load()
  {
    Console.WriteLine("Loading file");
  }

}


