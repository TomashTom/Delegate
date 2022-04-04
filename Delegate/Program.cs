// See https://aka.ms/new-console-template for more information
Func<int, int, string> SetCoordinates = (x, y) => { return $"X: {x}, Y: {y}"; };

Console.WriteLine(SetCoordinates(2, 3));

SetCoordinates = (x, y) => Execute(x, y);

Console.WriteLine(SetCoordinates(5, 5));


SetCoordinates = (x, y) => Divide(x, y);

Console.WriteLine(SetCoordinates(5, 5));


static string Execute(int x, int y)
{
    return "Only x: " + x.ToString();
}

static string Divide(int x, int y)
{
    return y > 0 ? "Division: " + (x / y).ToString() : 0.ToString();
}

