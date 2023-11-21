
namespace SquareCalculation.Services.Models;

public class Triangle : Figure
{
    readonly double A;
    readonly double B;
    readonly double C;
    readonly double[] sides = new double[3]; 

    public Triangle(double a, double b, double c)
    {
        A = a; B = b; C = c;
        sides[0] = A;
        sides[1] = B;
        sides[2] = C;
        SetTriangleName();
    }

    private void SetTriangleName()
    {
        if (A == B && B == C && A == C)
            Name = "равносторонний треугольник";
        else if (IsRightTriangle())
            Name = "прямоугольный треугольник";
        else
            Name = "треугольник";
    }
    public override double CalculateArea()
    {
        double S;
        double p = (A + B + C) / 2;
        S = Math.Sqrt(p * (p - A) * (p - B) * (p - C));

        return S;
    }

    private bool IsRightTriangle()
    {
        var maxSide = sides.Max();
        var catets = sides.Where(x=>x!=maxSide).ToArray();

        var isRightTriangle = Math.Pow(maxSide, 2) == Math.Pow(catets[0], 2) + Math.Pow(catets[1], 2);

        return isRightTriangle;
    }


}
