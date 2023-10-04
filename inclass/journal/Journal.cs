using System.IO; 

public class Journal
{
  public string _owner;
  public List<Entry> _entries = new List<Entry>();
  public string _description;

  public Journal(string owner, string description)
  {
    _owner = owner;
    _description = description;
  }

  public void AddEntryToJournal(Entry entry)
  {
    _entries.Add(entry);
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
  public void Save(string filename)
  {
    Console.WriteLine("Saving file");

    using (StreamWriter outputFile = new StreamWriter(filename))
    {
        foreach (Entry entry in _entries)
        {
          outputFile.WriteLine(entry._date);
          outputFile.WriteLine(entry._prompt);
          outputFile.WriteLine(entry._response);
        }
    }
  }

  public void Load(string filename)
  {
      Console.WriteLine("Loading file");

      string[] lines = System.IO.File.ReadAllLines(filename);

      for (int i = 0; i < lines.Length; i += 3)
      {
          string date = lines[i];
          string prompt = lines[i + 1];
          string response = lines[i + 2];

          Entry entry = new Entry(date, prompt, response);
          _entries.Add(entry);
      }
  }
}



