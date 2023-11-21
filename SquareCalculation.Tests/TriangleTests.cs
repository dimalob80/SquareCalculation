using SquareCalculation.Services.Models;

namespace SquareCalculation.Tests;

public class TriangleTests
{
    [Fact]
    public void CalculateAreaTest()
    {
        var triangle = new Triangle(2, 3, 4);

        var area = Math.Round(triangle.CalculateArea(),1);

        Assert.Equal(2.9, area); 

    }
}