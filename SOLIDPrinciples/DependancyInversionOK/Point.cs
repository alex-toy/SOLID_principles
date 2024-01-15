namespace DependancyInversionOK
{
    public class Point : IPoint
    {
        public double X_Coord { get; set; }
        public double Y_Coord { get; set; }
        public double Z_Coord { get; set; }

        public double GetXCoord()
        {
            return X_Coord;
        }

        public double GetYCoord()
        {
            return Y_Coord;
        }

        public double GetZCoord()
        {
            return Z_Coord;
        }

        public double XSquareDifference(IPoint P)
        {
            return Math.Pow(X_Coord - P.GetXCoord(), 2);
        }

        public double YSquareDifference(IPoint P)
        {
            return Math.Pow(Y_Coord - P.GetYCoord(), 2);
        }

        public double ZSquareDifference(Point P)
        {
            return Math.Pow(Z_Coord - P.GetZCoord(), 2);
        }
    }
}
