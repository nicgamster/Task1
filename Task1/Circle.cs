namespace Task1;

public class Circle : Figure
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("Radius must be positive.");
        }

        Radius = radius;
    }



    public override double Area()
    {
        return Math.PI * Radius * Radius;
    }
}
