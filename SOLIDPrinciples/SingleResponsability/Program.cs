using AreaSRP.Outputers;
using AreaWrong;
using ShapesLib.Shapes;

List<object> shapes = new List<object>()
{
    new Circle() { Radius = 3 },
    new Square() { Length = 2.2 },
    new Circle() { Radius = 8 },
    new Square() { Length = 8.6 },
};


Console.WriteLine("Area Calculator wrong : SRP not respected");

var areaCalculator = new AreaCalculator() { Shapes = shapes };
areaCalculator.OutputRawResult();
areaCalculator.OutputHtmlResult();
areaCalculator.OutputJsonResult();


Console.WriteLine("Area Calculator OK : SRP respected");

var areaCalculatorSRP = new AreaSRP.AreaCalculator() { Shapes = shapes };
Outputer outputer;

outputer = new RawOutputer() { Calculator = areaCalculatorSRP };
outputer.Output();

outputer = new HtmlOutputer() { Calculator = areaCalculatorSRP };
outputer.Output();

outputer = new JsonOutputer() { Calculator = areaCalculatorSRP };
outputer.Output();

