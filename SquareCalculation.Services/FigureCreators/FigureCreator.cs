using SquareCalculation.Services.Models;

namespace SquareCalculation.Services.FigureCreators
{
    public abstract class FigureCreator
    {
        public abstract string paramsName { get;}
        public abstract int paramsNumber { get; }
        public double[] Params;

        public static FigureCreator SelectCreator(int figureType)
        {
            FigureCreator figureCreator = null; 
            switch (figureType)
            {
                case (int)Figures.Треугольник:
                    figureCreator =  new TriangleCreator();
                    break;
                case (int)Figures.Круг:
                    figureCreator = new CircleCreator(); 
                    break;
                default:
                    break;
            }

            //if(figureCreator != null)
            //{ 
            //    figureCreator.Params = new double[figureCreator.paramsNumber];
            //}

            return figureCreator;
        }

    public virtual void InitParams()
    {
        Params = new double[paramsNumber];

    }
    public abstract Figure Create();

    }
}
