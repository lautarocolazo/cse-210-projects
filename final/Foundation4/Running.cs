public class Running : Activity
{
  private double _distance;

  public Running(string date, double length, double distance) : base(date, length)
  {
    _date = date;
    _length = length;
    _distance = distance;
  }


  public double GetSpeed()
  {
    return (_distance / _length) * 60;
  }

  public override double GetPace()
  {
    return _distance / _length;
  }

  public override string GetSummary()
  {
    string summary = $"{_date} {GetActivityType()} ({_length} min): Distance: {_distance} km, Speed: {GetSpeed():F2} kph, Pace: {GetPace():F2} min per km";

    return summary;
  }

  public override string GetActivityType()
  {
    return "Running";
  }
}
