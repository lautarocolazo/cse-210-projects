public class EternalGoal : Goal
{

  public override string Display()
  {
    return $"[] {_name} ({_description})";
  }

  public override void CreateGoal()
  {
    Console.Write("What is the name of your goal?: ");
    _name = Console.ReadLine();

    Console.Write("What is a short description of it?: ");
    _description = Console.ReadLine();

    Console.Write("What is the ammount of points associated with this goal?: ");
    _points = int.Parse(Console.ReadLine());
  }

  public override bool IsComplete()
  {
    return _isComplete;
  }

  public override void CompleteGoal()
  {
    _isComplete = false;
  }
}
