namespace DependancyInversionWrong
{
    public class Point
    {
        public double X_Coord { get; set; }
        public double Y_Coord { get; set; }

        public double XSquareDifference(Point P)
        {
            return Math.Pow(X_Coord - P.X_Coord, 2);
        }

        public double YSquareDifference(Point P)
        {
            return Math.Pow(Y_Coord - P.Y_Coord, 2);
        }
    }
}
