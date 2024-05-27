namespace CalculatorApp
{
    internal interface ICalculator
    {
        double Calc(double x, double y);
        char ActionType { get; }
    }
}
