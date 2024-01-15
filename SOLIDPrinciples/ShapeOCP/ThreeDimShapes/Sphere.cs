namespace ShapeOCP.ThreeDimShapes
{
    public class Sphere : ThreeDimShape
    {
        public double Radius { get; set; }

        public override double GetVolume()
        {
            return Math.Pow(Radius, 3) * Math.PI;
        }
    }
}
