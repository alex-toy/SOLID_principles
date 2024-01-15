namespace DependancyInversionOK
{
    public class Vector
    {
        public IPoint P1 { get; set; }
        public IPoint P2 { get; set; }

        public double Norm()
        {
            return Math.Sqrt(P1.XSquareDifference(P2) + P1.YSquareDifference(P2));
        }
    }
}
