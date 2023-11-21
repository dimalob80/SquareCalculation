using SquareCalculation.Services.Models;
using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("SquareCalculation.Tests")]

namespace SquareCalculation.Services.FigureCreators;

internal class TriangleCreator:FigureCreator
{

    public override string paramsName => "стороны";

    public override int paramsNumber => 3;

    public TriangleCreator()
    {
        Params = new double[paramsNumber];

    }

    public override Triangle Create()
    {
        if (isValidTriangle())

            return new Triangle(Params[0], Params[1], Params[2]);
        else
            throw new Exception("Введенные значения не позволяют построить треугольник. Сумма двух любых сторон должна быть больше третьей.");
    }


    private bool isValidTriangle()
    {
        return Params[0] + Params[1] > Params[2] & Params[0] + Params[2] > Params[1] & Params[1] + Params[2] > Params[0];
    }


}
