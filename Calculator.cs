namespace CalculatorApp
{
    internal class Calculator
    {

        public class Add : ICalculator
        {
            public char ActionType => '+';

            public double Calc(double x, double y)
            {
                return x + y;
            }
        }

        public class Substract : ICalculator
        {
            public char ActionType => '-';

            public double Calc(double x, double y)
            {
                return x - y;
            }
        }

        private double Multiply(double a, double b)
        {
            return a * b;
        }

        private double Divide(double a, double b)
        {
            if (a == 0 || b == 0)
            {
                throw new InvalidOperationException("Cannot divide by 0");
            }
            return a / b;

        }

        //public double PerformOperation(double a, double b, char actionType)
        //{
        //    return actionType switch
        //    {
        //        '+' => Add(a, b),
        //        '-' => Subtract(a, b),
        //        '/' => Divide(a, b),
        //        '*' => Multiply(a, b),
        //        _ => throw new InvalidOperationException("Invalid action type")
        //    };
        //}
    }
}
