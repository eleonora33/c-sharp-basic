
// Task 1
using System.Data.Common;

//Console.WriteLine("Enter first number:");
//var numberOne = Console.ReadLine();
//bool numOne = int.TryParse(numberOne, out int parsedNumber1);

//Console.WriteLine("Enter second number:");
//var numberTwo = Console.ReadLine();
//bool numTwo = int.TryParse(numberTwo, out int parsedNumber2);

//Console.WriteLine("Enter operator:");
//var operation = Console.ReadLine();

//var result = 0;

//if(operation == "+")
//{
//    result = parsedNumber1 + parsedNumber2;
//}
//else if(operation == "-")
//{
//    result = parsedNumber1 - parsedNumber2;
//}
//else if (operation == "*")
//{
//    result = parsedNumber1 * parsedNumber2;
//}
//else if(operation == "/")
//{
//    result = parsedNumber1 / parsedNumber2;
//}
//else 
//{
//    Console.WriteLine("Enter valid operator");
//}

//Console.WriteLine("Calculate...{0}", result);
//Console.WriteLine($"Calculate...{result}");
//Console.WriteLine(@$"Calculate...
//{result}
//I'm in new line/");

//switch (operation)
//{
//    case "+":
//        Console.WriteLine(parsedNumber1 + parsedNumber2); 
//    break;
//    case "-":
//        Console.WriteLine(parsedNumber1 - parsedNumber2);
//    break;
//    case "*":
//        Console.WriteLine(parsedNumber1 * parsedNumber2);   
//    break;
//    case "/":
//        Console.WriteLine(parsedNumber1 / parsedNumber2);   
//    break;

//    default:
//    Console.WriteLine("Enter valid operator");
//    break;
//}

//Task 2

Console.WriteLine("Enter four numbers:");

int first = int.Parse(Console.ReadLine());
int second = int.Parse(Console.ReadLine());
int third = int.Parse(Console.ReadLine());
int fourth = int.Parse(Console.ReadLine());

Console.WriteLine(@$"Average number is:
{(first + second + third + fourth) / 4}");

//Task 3 

Console.WriteLine("Enter two numbers");

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

Console.WriteLine(@$"Swap Numbers:
{b}
{a}");



