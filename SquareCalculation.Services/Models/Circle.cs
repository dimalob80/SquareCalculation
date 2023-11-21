using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareCalculation.Services.Models;

public class Circle : Figure
{
    public double Radius { get; private set; }
    public Circle(double r) 
    {
        Radius = r;
        Name = "окружность";
    }
    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

}
