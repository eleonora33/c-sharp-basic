
// Task 1
using System.Data.Common;

Console.WriteLine("Enter first number:");
var numberOne = Console.ReadLine();
bool numOne = int.TryParse(numberOne, out int parsedNumber1);

Console.WriteLine("Enter second number:");
var numberTwo = Console.ReadLine();
bool numTwo = int.TryParse(numberTwo, out int parsedNumber2);

Console.WriteLine("Enter operator:");
var operation = Console.ReadLine();

var result = 0;

if(operation == "+")
{
    result = parsedNumber1 + parsedNumber2;
}
else if(operation == "-")
{
    result = parsedNumber1 - parsedNumber2;
}
else if (operation == "*")
{
    result = parsedNumber1 * parsedNumber2;
}
else if(operation == "/")
{
    result = parsedNumber1 / parsedNumber2;
}
else 
{
    Console.WriteLine("Enter valid operator");
}

Console.WriteLine("Calculate...{0}", result);
Console.WriteLine("Calculate...{0}fjksdjfk {1} sdsadshkj {2}", result, "Zdravo", 55);
Console.WriteLine($"Calculate...{result}");
Console.WriteLine(@$"Calculate...
{result}
I'm in new line/");


switch (operation)
{
    case "+":
    default:
        break;
}


