public class StationaryBike : Activity
{
  private double _speed;

  public StationaryBike(string date, double length, double speed) : base(date, length)
  {
    _date = date;
    _length = length;
    _speed = speed;
  }

  public double GetDistance()
  {
    return (_speed / 60) * _length;
  }

  public override double GetPace()
  {
    return (_length / GetDistance());
  }

  public override string GetSummary()
  {
    string summary = $"{_date} {GetActivityType()} ({_length} min): Distance: {GetDistance():F2} km, Speed: {_speed} kph, Pace: {GetPace():F2} min per km";

    return summary;
  }

  public override string GetActivityType()
  {
    return "Stationary Bike";
  }
}

