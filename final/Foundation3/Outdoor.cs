public class Outdoor : Event
{
  private string _forecast;

  public Outdoor(string title, string description, string date, string time, Address address, string type, string forecast) : base(title, description, date, time, address, type)
  {
    _forecast = forecast;
  }


}
