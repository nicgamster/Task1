using Xunit;

namespace Task1.Tests;

public class TriangleTests
{
    [Fact]
    public void CorrectTriangle_AreaCalculatedCorrectly()
    {
        // Arrange
        Figure triangle = new Triangle(5, 5, 6);

        // Act
        double result = triangle.Area();

        // Assert
        Assert.Equal(12, result);
    }

    [Fact]
    public void Constructor_InvalidTriangle_ThrowsException()
    {
        // Arrange
        double side1 = 1;
        double side2 = 2;
        double side3 = 3;

        // Act
        var ex = Assert.Throws<ArgumentException>(() => new Triangle(side1, side2, side3));

        //Assert
        Assert.Equal("The provided sides do not form a valid triangle.", ex.Message);
    }

    [Fact]
    public void Constructor_NegativeSide_ThrowsException()
    {
        // Arrange
        double side1 = -1;
        double side2 = 2;
        double side3 = 3;

        // Act
        var ex = Assert.Throws<ArgumentException>(() => new Triangle(side1, side2, side3));

        //Assert
        Assert.Equal("Sides must be positive.", ex.Message);
    }

    [Fact]
    public void Constructor_ZeroSide_ThrowsException()
    {
        // Arrange
        double side1 = 0;
        double side2 = 2;
        double side3 = 3;

        // Act
        var ex = Assert.Throws<ArgumentException>(() => new Triangle(side1, side2, side3));
        
        //Assert
        Assert.Equal("Sides must be positive.", ex.Message);
    }


    [Fact]
    public void IsRectangularTrue()
    {
        // Arrange
        Triangle triangle = new Triangle(3.5, 2.8, 2.1);

        // Act
        bool result = triangle.IsRectangular();

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsRectangularFalse()
    {
        // Arrange
        Triangle triangle = new Triangle(5, 5, 6);

        // Act
        bool result = triangle.IsRectangular();

        // Assert
        Assert.False(result);
    }
}
