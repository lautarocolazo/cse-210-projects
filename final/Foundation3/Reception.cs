public class Reception : Event
{
  private int _rsvp;

  public Reception(string title, string description, string date, string time, Address address, string type, int rsvp) : base(title, description, date, time, address, type)
  {
    _rsvp = rsvp;
  }


}
