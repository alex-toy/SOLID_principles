namespace DependancyInversionOK
{
    public interface IPoint
    {
        double GetXCoord();
        double GetYCoord();
        double XSquareDifference(IPoint P);
        double YSquareDifference(IPoint P);
    }
}
