using Xunit;

namespace Task1.Tests;

public class CircleTests
{
	[Fact]
	public void Area()
	{
		// Arrange
		Figure circle = new Circle(2);

		// Act
		double result = circle.Area();

		// Assert
		Assert.Equal(Math.PI * 4, result);
	}
}