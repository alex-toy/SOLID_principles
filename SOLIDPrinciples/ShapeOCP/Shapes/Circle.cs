namespace ShapeOCP.Shapes
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }
    }
}
