namespace AreaSRP.Outputers
{
    public class JsonOutputer : Outputer
    {
        public override void Output()
        {
            double sumAreas = Calculator.SumAreas();
            Console.WriteLine($"{{ areas : {sumAreas} }}");
        }
    }
}
