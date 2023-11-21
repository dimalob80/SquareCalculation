using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareCalculation.Services.Models;

public abstract class Figure
{
    public string Name { get; protected set; }
    public abstract double CalculateArea();
}
