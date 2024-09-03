using Xunit;

namespace Task1.Tests;

public class TriangleTests
{
	[Fact]
	public void Area()
	{
		// Arrange
		Figure triangle = new Triangle(5, 5, 6);

		// Act
		double result = triangle.Area();

		// Assert
		Assert.Equal(12, result);
	}

	[Fact]
	public void AreaZero()
	{
		// Arrange
		Figure triangle = new Triangle(5, 5, 10);

		// Act
		double result = triangle.Area();

		// Assert
		Assert.Equal(0, result);
	}

	[Fact]
	public void AreaNaN()
	{
		// Arrange
		Figure triangle = new Triangle(5, 5, 11);

		// Act
		double result = triangle.Area();

		// Assert
		Assert.Equal(double.NaN, result);
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
