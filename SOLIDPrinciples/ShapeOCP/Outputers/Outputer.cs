namespace ShapeOCP.Outputers
{
    public abstract class Outputer
    {
        public AreaCalculator Calculator { get; set; }

        public abstract void Output();
    }
}
