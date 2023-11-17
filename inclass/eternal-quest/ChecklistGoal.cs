public class ChecklistGoal : Goal
{

  public int _timesToAccomplished { get; set; }
  public int _currentTimesAccomplished { get; set; }
  public int _bonusPoints { get; set; }

  public override string Display()
  {
    if (_isComplete == true)
    {
      return $"[X] {_name} ({_description}) -- Currently completed: {_currentTimesAccomplished}/{_timesToAccomplished}";
    }
    else
    {
      return $"[ ] {_name} ({_description}) -- Currently completed: {_currentTimesAccomplished}/{_timesToAccomplished}";
    }
  }

  public override void CreateGoal()
  {
    Console.Write("What is the name of your goal?: ");
    _name = Console.ReadLine();

    Console.Write("What is a short description of it?: ");
    _description = Console.ReadLine();

    Console.Write("What is the ammount of points associated with this goal?: ");
    _points = int.Parse(Console.ReadLine());
    
    Console.Write("How many times does this goal need to be accomplished for a bonus?: ");
    _timesToAccomplished = int.Parse(Console.ReadLine());

    Console.Write("What is the bonus for accomplishing it that many times?: ");
    _bonusPoints = int.Parse(Console.ReadLine());
  }

  public override bool IsComplete()
  {
    return _isComplete;
  }

  public override void CompleteGoal()
  {
    _currentTimesAccomplished += 1;

    if (_currentTimesAccomplished == _timesToAccomplished)
    {
      Console.WriteLine("Good job! You got all the times that you proposed yourself!");
      _points += _bonusPoints;
      _isComplete = true;
      return;
    }

  }

}
