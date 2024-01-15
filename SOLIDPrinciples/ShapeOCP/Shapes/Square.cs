namespace ShapeOCP.Shapes
{
    public class Square : Shape
    {
        public double Length { get; set; }

        public override double Area()
        {
            return Math.Pow(Length, 2);
        }
    }
}
