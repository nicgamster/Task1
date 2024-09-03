namespace Task1;

public class Triangle : Figure
{
    private double _side1;
    private double _side2;
    private double _side3;

    public Triangle(double side1, double side2, double side3)
    {
        _side1 = side1;
        _side2 = side2;
        _side3 = side3;
    }



    public override double Area()
    {
        double halfPerimeter = (_side1 + _side2 + _side3) / 2;
        double a = halfPerimeter - _side1;
        double b = halfPerimeter - _side2;
        double c = halfPerimeter - _side3;

        return Math.Sqrt(halfPerimeter * a * b * c);
    }

    public bool IsRectangular()
    {
        double side1Squared = _side1 * _side1;
        double side2Squared = _side2 * _side2;
        double side3Squared = _side3 * _side3;

        double sum = side1Squared + side2Squared + side3Squared;
        double maxSide = Math.Max(Math.Max(side1Squared, side2Squared), side3Squared);

        return maxSide == sum - maxSide;
    }
}
