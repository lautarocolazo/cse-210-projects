public class Scripture
{
  private string _scripture = string.Empty;
  private List<string> _scriptures = new List<string>{
    "Mosiah 2:41: And moreover, I would desire that ye should consider on the blessed and ahappy state of those that keep the commandments of God. For behold, they are bblessed in all things, both temporal and spiritual; and if they hold out cfaithful to the end they are received into dheaven, that thereby they may dwell with God in a state of never-ending happiness. O remember, remember that these things are true; for the Lord God hath spoken it."
  };
  public Scripture()
  {
    _scripture = PickScripture();
  }

  private string PickScripture()
  {

    Random random = new Random();
    int randomIndex = random.Next(_scriptures.Count);

    string randomElement = _scriptures[randomIndex];

    return randomElement;
  }

  public string GetScripture()
  {
    return _scripture;
  }

public void HideWords()
{
    string[] words = _scripture.Split(' ');

    List<string> nonHiddenWords = words.Where(word => word != "___").ToList();

    if (nonHiddenWords.Count == 0)
    {
        return;
    }

    Random random = new Random();
    HashSet<int> indicesToHide = new HashSet<int>();
    while (indicesToHide.Count < 3)
    {
        int randomIndex = random.Next(nonHiddenWords.Count);
        indicesToHide.Add(randomIndex);
    }

    foreach (int index in indicesToHide)
    {
        string wordToHide = nonHiddenWords[index];
        int originalIndex = Array.IndexOf(words, wordToHide);
        words[originalIndex] = new string('_', wordToHide.Length);
    }

    _scripture = string.Join(' ', words);
}

}
