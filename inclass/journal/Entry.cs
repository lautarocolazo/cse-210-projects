public class Entry
{
  public string _date;
  public string _prompt;
  public string _response;

  public Entry(string date, string prompt, string response = null)
  {
    _date = date;
    _prompt = prompt;
    _response = response;
  }

  public void DisplayEntry()
  {
    Console.WriteLine($"Date: {_date}");
    Console.WriteLine($"Prompt: {_prompt}");
    Console.WriteLine($"{_response}" + Environment.NewLine);
  }

  public void UpdateEntry()
  {
    Console.WriteLine("Updating entry");
  }

  public void DeleteEntry()
  {
    Console.WriteLine("DeletingEntry");
  }
}
