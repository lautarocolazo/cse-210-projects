class VipElevator : Elevator
{
    protected string _code;

    public VipElevator(int currentFloor, int bottomFloor, int topFloor, string code) : base(currentFloor, bottomFloor, topFloor)
    {
        _doorsOpen = false;
        _code = code;
    }

    public bool CheckCode(string code)
    {
        if (code == _code)
        {
            return true;
        }
        return false;
    }
}
