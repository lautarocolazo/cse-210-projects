class Elevator
{
    protected int _currentFloor;
    protected int _bottomFloor;
    protected int _topFloor;
    protected bool _doorsOpen;

    public Elevator(int currentFloor, int bottomFloor, int topFloor)
    {
        _currentFloor = currentFloor;
        _bottomFloor = bottomFloor;
        _topFloor = topFloor;
        _doorsOpen = false;
    }

    public void ChangeFloor(int floor)
    {
        _currentFloor = floor;
    }
    
    public string GetDoorsOpen()
    {
      if (_doorsOpen){
        return $"The doors are open";
      }
      return $"The doors are not open";
    }

    public void OpenDoors()
    {
        _doorsOpen = true;
    }

    public void CloseDoors()
    {
        _doorsOpen = false;
    }

    public string DisplayFloor()
    {
        return $"The floor is {_currentFloor}";
    }

    public string ListFloors()
    {
        List<int> _floors = new List<int>();

        for (int i = _bottomFloor; i <= _topFloor; i++)
        {
            _floors.Add(i);
        }

        string result = string.Join(", ", _floors);

        return result;
    }
}
