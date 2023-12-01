public class Swimming : Activity
{
  private int _laps;

  public Swimming(string date, double length, int laps) : base(date, length)
  {
    _date = date;
    _length = length;
    _laps = laps;
  }

  public double GetDistance()
  {
    return (_laps * 50.0) / 1000;
  }

  public double GetSpeed()
  {
    return (GetDistance() / _length) * 60;
  }

  public override double GetPace()
  {
    return _length / GetDistance();   
  }

  public override string GetSummary()
  {
    string summary = $"{_date} {GetActivityType()} ({_length} min): Distance: {GetDistance():F2} km, Speed: {GetSpeed():F2} kph, Pace: {GetPace():F2} min per km";

    return summary;
  }

  public override string GetActivityType()
  {
    return "Swimming";
  }
}
