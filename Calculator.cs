namespace CalculatorApp
{
    public class Add : ICalculator
    {
        public char ActionType => '+';

        public double Execute(double x, double y)
        {
            return x + y;
        }
    }

    public class Subtract : ICalculator
    {
        public char ActionType => '-';

        public double Execute(double x, double y)
        {
            return x - y;
        }
    }

    public class Multiply : ICalculator
    {
        public char ActionType => '*';

        public double Execute(double x, double y)
        {
            return x * y;
        }
    }

    public class Divide : ICalculator
    {
        public char ActionType => '/';

        public double Execute(double x, double y)
        {
            if (y == 0)
            {
                throw new InvalidOperationException("Cannot divide from 0");
            }

            return x / y;
        }
    }
}
