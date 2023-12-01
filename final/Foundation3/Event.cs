public class Event
{
  protected string _title;
  protected string _description;
  protected string _date;
  protected string _time;
  protected Address _address;
  protected string _type;

  public Event(string title, string description, string date, string time, Address address, string type)
  {
    _title = title;
    _description = description;
    _date = date;
    _time = time;
    _address = address;
    _type = type;
  }
  
  public string StandardDetails()
  {
    return $"{_title}, {_description}, {_date}, {_time}, {_address.GetFullAddress()}";
  }

  public string ShortDescription()
  {
    return $"Event type: {_type}" +
      Environment.NewLine +
      $"{_title}, {_date}";
  }

  public string GetAddress()
  {
    return _address.GetFullAddress();
  }

}
