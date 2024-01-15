using ShapeOCP.ThreeDimShapes;

namespace ShapeOCP
{
    public class VolumeCalculator : AreaCalculator
    {
        public List<ThreeDimShape> ThreeDimShapes { get; set; }

        public double SumVolumes() // if alone, an error occurs
        {
            double sumVolumes = 0;

            foreach (var shape in ThreeDimShapes) sumVolumes += shape.GetVolume();

            return sumVolumes;
        }

        public override double SumAreas() // Must be added in order to prevent the error
        {
            return SumVolumes();
        }
    }
}
