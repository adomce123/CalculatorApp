// See https://aka.ms/new-console-template for more information

using CalculatorApp;

string input1 = Console.ReadLine();
string input2 = Console.ReadLine();
char actionType = char.Parse(Console.ReadLine());


double.TryParse(input1, out double number1);
Console.WriteLine(number1);

double.TryParse(input2, out double number2);
Console.WriteLine(number2);

var calculator = new Calculator();
var result = calculator.PerformOperation(number1, number2, actionType);
Console.WriteLine($"result {result}");

//var calculator = new Calculator();
//var sum = calculator.Add(number1, number2);

//Console.WriteLine($"Sum: {sum}");

//var substract = calculator.Subtract(number1, number2);

//Console.WriteLine($"substract: {substract}");

//var divide = calculator.Divide(number1, number2);

//Console.WriteLine($"Divide: {divide}");

//var multiply = calculator.Multiply(number1, number2);

//Console.WriteLine($"Multiply: {multiply}");