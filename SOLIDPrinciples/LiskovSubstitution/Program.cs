using ShapeOCP;
using ShapeOCP.Outputers;
using ShapeOCP.Shapes;
using ShapeOCP.ThreeDimShapes;

Console.WriteLine("Liskov Substitution");

List<Shape> shapes = new List<Shape>()
{
    new Circle() { Radius = 3 },
    new Square() { Length = 2.2 },
    new Circle() { Radius = 8 },
    new Square() { Length = 8.6 },
};

List<ThreeDimShape> threeDimshapes = new List<ThreeDimShape>()
{
    new Sphere() { Radius = 3 },
    new Cube() { Length = 2.2 },
    new Sphere() { Radius = 8 },
    new Cube() { Length = 8.6 },
};
Outputer outputer;

var areaCalculator = new AreaCalculator() { Shapes = shapes };
outputer = new HtmlOutputer() { Calculator = areaCalculator };
outputer.Output();


var volumeCalculator = new VolumeCalculator() { ThreeDimShapes = threeDimshapes };
outputer = new HtmlOutputer() { Calculator = volumeCalculator };
outputer.Output(); // throws an error because method SumAreas in AreaCalculator will be called !!