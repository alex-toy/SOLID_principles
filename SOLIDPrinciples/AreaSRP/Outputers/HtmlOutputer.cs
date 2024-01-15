namespace AreaSRP.Outputers
{
    public class HtmlOutputer : Outputer
    {
        public override void Output()
        {
            double sumAreas = Calculator.SumAreas();
            Console.WriteLine($"<h1>The sum of areas is {sumAreas}</h1>");
        }
    }
}
