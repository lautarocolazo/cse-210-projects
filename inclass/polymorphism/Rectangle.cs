class Rectangle : Shape
{
  private double _width;
  private double _height;

  public Rectangle(string color, double width, double height) : base(color)
  {
    _width = width;
    _height = height;
  }

  public override double GetArea()
  {
    return Math.Pow(_width, 2) + Math.Pow(_height, 2);
  }
}
