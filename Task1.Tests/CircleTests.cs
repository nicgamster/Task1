using Xunit;

namespace Task1.Tests;

public class CircleTests
{
    [Fact]
    public void CorrectCircle_AreaCalculatedCorrectly()
    {
        // Arrange
        Figure circle = new Circle(2);

        // Act
        double result = circle.Area();

        // Assert
        Assert.Equal(Math.PI * 4, result);
    }

    [Fact]
    public void NegativeRadius_ThrowsException()
    {
        // Arrange
        double radius = -1;

        // Act
        var ex = Assert.Throws<ArgumentException>(() => new Circle(radius));

        // Assert
        Assert.Equal("Radius must be positive.", ex.Message);
    }

    [Fact]
    public void ZeroRadius_ThrowsException()
    {
        // Arrange
        double radius = 0;

        // Act
        var ex = Assert.Throws<ArgumentException>(() => new Circle(radius));

        // Assert
        Assert.Equal("Radius must be positive.", ex.Message);
    }
}