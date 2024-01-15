namespace AreaSRP.Outputers
{
    public class RawOutputer : Outputer
    {
        public override void Output()
        {
            double sumAreas = Calculator.SumAreas();
            Console.WriteLine($"The sum of areas is {sumAreas}");
        }
    }
}
