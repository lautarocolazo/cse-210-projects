public class Entry
{
  public string _date;
  public string _prompt;
  public string _reponse;

  public Entry(string date, string prompt, string response)
  {
    _date = date;
    _prompt = prompt;
    _reponse = response;
  }

  public void DisplayEntry()
  {
    Console.WriteLine($"{_date}");
    Console.WriteLine($"{_prompt}");
    Console.WriteLine($"{_reponse}");
  }

  public void UpdateEntry()
  {
    Console.WriteLine("Updateing entry");
  }

  public void DeleteEntry()
  {
    Console.WriteLine("DeletingEntry");
  }
}
