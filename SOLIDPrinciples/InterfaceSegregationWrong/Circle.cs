namespace InterfaceSegregationWrong
{
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public double Area()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }

        public double Volume()
        {
            throw new NotImplementedException();
        }
    }
}
