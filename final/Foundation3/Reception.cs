public class Reception : Event
{
  private string _rsvp;

  public Reception(string title, string description, string date, string time, Address address, string type, string rsvp) : base(title, description, date, time, address, type)
  {
    _rsvp = rsvp;
  }

  public string FullDetails()
  {
    return $"Event type: {_type}" +
    Environment.NewLine +
    $"{_title}, {_description}, {_date}, {_time}, {_address.GetFullAddress()}" +
    Environment.NewLine +
    $"Email to RVSP: {_rsvp}";
  }

  public void DisplayRvsp()
  {
    Console.WriteLine($"The email to RVSP is: {_rsvp}");
  }

}
