public abstract class Goal
{
  protected string _name;
  protected string _description;
  protected int _points;
  protected bool _isComplete;

  public Goal(string name, string description)
  {
    _name = name;
    _description = description;
    _isComplete = false;

  }

  public Goal()
  {

  }

  public abstract void CreateGoal();

  public abstract string Display();

  public abstract bool IsComplete();

  public abstract void CompleteGoal();


  public int RecordEvent(int points, Goal goal)
  {
    points += goal.GetPoints();

    return points;
  }

  public int GetPoints()
  {
    return _points;
  }

  public string GetName()
  {
    return _name;
  }

  public string GetDescription()
  {
    return _description;
  }

  public bool GetIsComplete()
  {
    return _isComplete;
  }

  public virtual void SetProperties(string name, string description, int points, bool isComplete)
  {
      _name = name;
      _description = description;
      _points = points;
      _isComplete = isComplete;
  }
}
