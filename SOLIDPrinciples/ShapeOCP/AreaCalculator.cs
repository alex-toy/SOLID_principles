using ShapeOCP.Shapes;

namespace ShapeOCP
{
    public class AreaCalculator
    {
        public List<Shape>? Shapes { get; set; }

        public virtual double SumAreas()
        {
            double sumAreas = 0;

            foreach (var shape in Shapes) sumAreas += shape.Area();

            return sumAreas;
        }
    }
}
