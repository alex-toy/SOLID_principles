using ShapeOCP;
using ShapeOCP.Outputers;
using ShapeOCP.Shapes;

Console.WriteLine("Open Close");

List<Shape> shapes = new List<Shape>()
{
    new Circle() { Radius = 3 },
    new Square() { Length = 2.2 },
    new Circle() { Radius = 8 },
    new Square() { Length = 8.6 },
};

var areaCalculator = new AreaCalculator() { Shapes = shapes };

Outputer outputer;

outputer = new RawOutputer() { Calculator = areaCalculator };
outputer.Output();

outputer = new HtmlOutputer() { Calculator = areaCalculator };
outputer.Output();

outputer = new JsonOutputer() { Calculator = areaCalculator };
outputer.Output();