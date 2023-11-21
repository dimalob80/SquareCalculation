using SquareCalculation.Services.FigureCreators;

namespace SquareCalculation.Tests;

public class TriangleCreatorTests
{
    [Fact]
    public void CreateValidTriangle()
    {

        var creator = new TriangleCreator();

        creator.Params[0] = 2;
        creator.Params[1] = 3;
        creator.Params[2] = 4;

        var triangle = creator.Create(); 

        Assert.NotNull(triangle);
        Assert.Equal("треугольник", triangle.Name); 
    }

    [Fact]
    public void CreateValidRightTriangle()
    {

        var creator = new TriangleCreator();

        creator.Params[0] = 3;
        creator.Params[1] = 4;
        creator.Params[2] = 5;

        var triangle = creator.Create();

        Assert.NotNull(triangle);
        Assert.Equal("прямоугольный треугольник", triangle.Name);
    }

    [Fact]
    public void Create_InvalidParameters_ThrowException()
    {
        var creator = new TriangleCreator();

        creator.Params[0] = 1;
        creator.Params[1] = 2;
        creator.Params[2] = 3;

        Assert.Throws<Exception>(() => creator.Create());
    }

}
