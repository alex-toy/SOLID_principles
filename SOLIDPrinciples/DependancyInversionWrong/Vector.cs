namespace DependancyInversionWrong
{
    public class Vector
    {
        public Point P1 { get; set; }
        public Point P2 { get; set; }

        public double Norm()
        {
            return Math.Sqrt(P1.XSquareDifference(P2) + P1.YSquareDifference(P2));
        }
    }
}
