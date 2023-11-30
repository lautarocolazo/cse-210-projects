public class Lecture : Event
{
  private string _speaker;
  private int _limitedCapacity;

  public Lecture(string title, string description, string date, string time, Address address, string speaker, string type, int limitedCapacity) : base(title, description, date, time, address, type)
  {
    _speaker = speaker;
    _limitedCapacity = limitedCapacity;
  }

  public string GetSpeaker()
  {
    return _speaker;
  }

  public int GetCapacity()
  {
    return _limitedCapacity;
  }

}
