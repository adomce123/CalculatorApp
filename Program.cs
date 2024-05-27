using CalculatorApp;
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Enter first number:");
string input1 = Console.ReadLine();
double.TryParse(input1, out double number1);

Console.WriteLine("Enter second number:");
string input2 = Console.ReadLine();
double.TryParse(input2, out double number2);

Console.WriteLine("Enter operation (+, -, /, *):");
char actionType = char.Parse(Console.ReadLine());

var serviceProvider = new ServiceCollection()
    .AddTransient<ICalculator, Add>()
    .AddTransient<ICalculator, Subtract>()
    .AddTransient<ICalculator, Multiply>()
    .AddTransient<ICalculator, Divide>()
    .BuildServiceProvider();

var services = serviceProvider.GetServices<ICalculator>();

var operation = services.FirstOrDefault(calc => calc.ActionType == actionType);

var result = operation?.Execute(number1, number2);

Console.WriteLine($"Result: {result}");
