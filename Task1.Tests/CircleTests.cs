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
    public void FlatCircle_AreaIsZero()
    {
        // Arrange
        Figure circle = new Circle(0);

        // Act
        double result = circle.Area();

        // Assert
        Assert.Equal(0, result);
    }
}