using SquareCalculation.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareCalculation.Services.FigureCreators;

public class CircleCreator : FigureCreator
{
    public CircleCreator()
    {
        Params = new double[paramsNumber];
    }
    public override string paramsName => "радиус";

    public override int paramsNumber => 1;



    public override Figure Create()
    {
        return new Circle(Params[0]);
    }
}
