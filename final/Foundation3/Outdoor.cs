public class Outdoor : Event
{
  private string _forecast;

  public Outdoor(string title, string description, string date, string time, Address address, string type, string forecast) : base(title, description, date, time, address, type)
  {
    _forecast = forecast;
  }

  public string FullDetails()
  {
    return $"Event type: {_type}" +
    Environment.NewLine +
    $"{_title}, {_description}, {_date}, {_time}, {_address.GetFullAddress()}" +
    Environment.NewLine +
    $"The expected forecast for the activity: {_forecast}";
  }


}
