namespace Task1;

public class Circle : Figure
{
	public double _radius { get; set; }

	public Circle(double radius)
	{
        _radius = radius;
	}



	public override double Area()
	{
		return Math.PI * _radius * _radius;
	}
}
