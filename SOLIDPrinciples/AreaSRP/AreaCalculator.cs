using ShapesLib.Shapes;

namespace AreaSRP
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
    }
}
