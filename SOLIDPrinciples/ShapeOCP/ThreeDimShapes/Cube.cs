namespace ShapeOCP.ThreeDimShapes
{
    public class Cube : ThreeDimShape
    {
        public double Length { get; set; } 
        public override double GetVolume()
        {
            return Math.Pow(Length, 3);
        }
    }
}
