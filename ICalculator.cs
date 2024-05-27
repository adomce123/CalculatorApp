namespace CalculatorApp
{
    internal interface ICalculator
    {
        double Execute(double x, double y);
        char ActionType { get; }
    }
}
