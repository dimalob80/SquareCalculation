

using SquareCalculation.Services;
using SquareCalculation.Services.FigureCreators;

var isValidFigureType = false;

var figureNames = Enum.GetNames<Figures>();

try
{
    int figureType = GetFigureType();

    var creator = FigureCreator.SelectCreator(figureType);

    SetFigureParams(creator);

    var figure = creator.Create();
    Console.WriteLine($"Фигура: {figure.Name}");
    Console.WriteLine($"{creator.paramsName}: {string.Join(',', creator.Params)}");
    Console.WriteLine($"Площадь: {figure.CalculateArea()}");
}
catch (Exception ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}

Console.ReadLine();


//---------------------------------------------//
void ShowFigureTypes()
{
    Console.WriteLine($"Выберите фигуру:");

    int result = -1;

    for (int i = 0; i < figureNames.Length; i++)
    {
        Console.WriteLine($"{i + 1} - {figureNames[i]}");
    }

}

int GetFigureType()
{
    int figureType = 0;

    do
    {
        ShowFigureTypes();

        var value = Console.ReadLine();

        if (!int.TryParse(value, out figureType))
        {
            Console.WriteLine($"Некорректный ввод.");
        }
        else if (figureType == 0 || figureType > figureNames.Length)
        {
            Console.WriteLine($"Некорректный ввод.");
        }
        else
        {
            isValidFigureType = true;
        }

    }
    while (!isValidFigureType);

    return figureType;
}

void SetFigureParams(FigureCreator creator)
{
    Console.WriteLine($"Введите {creator.paramsName} ({creator.paramsNumber} значение(я)):");

    for (int i = 0; i < creator.paramsNumber; i++)
    {
        var isValidParameter = false;

        do
        {
            if (!Double.TryParse(Console.ReadLine(), out double param))
            {
                Console.WriteLine($"Некорректный ввод.");
                isValidParameter = false;
            }

            creator.Params[i] = param;
            isValidParameter = true;

        }
        while (!isValidParameter);
    }
}
