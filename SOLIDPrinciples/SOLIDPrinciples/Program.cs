using SOLIDPrinciples;
using SOLIDPrinciples.Shapes;

Console.WriteLine("Area Calculator");

List<object> shapes = new List<object>()
{
    new Circle() { Radius = 3 },
    new Square() { Length = 2.2 },
    new Circle() { Radius = 8 },
    new Square() { Length = 8.6 },
};

var areaCalculator = new AreaCalculator() { Shapes = shapes };
areaCalculator.OutputRawResult();
areaCalculator.OutputHtmlResult();
areaCalculator.OutputJsonResult();
