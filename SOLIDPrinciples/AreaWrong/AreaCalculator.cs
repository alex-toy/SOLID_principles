using ShapesLib.Shapes;

namespace AreaWrong
{
    public class AreaCalculator
    {
        public List<object>? Shapes { get; set; }

        public double SumAreas()
        {
            double sumAreas = 0;

            foreach (var shape in Shapes)
            {
                if (shape is Square) sumAreas += Math.Pow(((Square)shape).Length, 2);
                else if (shape is Circle) sumAreas += Math.Pow(((Circle)shape).Radius, 2) * Math.PI;
            }

            return sumAreas;
        }

        public void OutputRawResult()
        {
            double sumAreas = SumAreas();
            Console.WriteLine($"The sum of areas is {sumAreas}");
        }

        public void OutputHtmlResult()
        {
            double sumAreas = SumAreas();
            Console.WriteLine($"<h1>The sum of areas is {sumAreas}</h1>");
        }

        public void OutputJsonResult()
        {
            double sumAreas = SumAreas();
            Console.WriteLine($"{{ areas : {sumAreas} }}");
        }
    }
}
