//Task 1

//int[] userInputIntArray = new int[6];
//int sum = 0;

//for (int i = 0; i < userInputIntArray.Length; i++)
//{
//int userInput = int.Parse(Console.ReadLine());
//Console.WriteLine(@$"* Enter integer no.1:
//   * {userInput}");

//    if (userInput % 2 == 0)
//    { 
//        sum += userInput;
//    }
//}
//Console.WriteLine(@$" * Expected Output:
//    * The result is: {sum}");

//Task 2

//internal class Program
//{
//    private static object? item;

//    private static void Main(string[] args)
//    {
//        string[] studentsOfG1 = { "Eli", "Kalina", "Marjan", "Tose", "Jana" };
//        string[] studentsOfG2 = { "John", "Doe", "Petko", "Stanko", "Mitko" };


//        Console.WriteLine(" * Enter student group: ( there are 1 and 2 )");
//        int chooseStudentsGroup = int.Parse(Console.ReadLine());

//        if (chooseStudentsGroup == 1)
//        {
//            Console.WriteLine(@"* Expected Output:
// * The Students in G1 are: ");

//            foreach (var item in studentsOfG1)
//            {
//                Console.WriteLine(" * {0} ", item);
//            }
//        }

//        if (chooseStudentsGroup == 2)
//        {
//            Console.WriteLine(@"* Expected Output:
// * The Students in G2 are:");
//            foreach (var i in studentsOfG2)
//            {
//                Console.WriteLine(" * {0} ", i);
//            }

//        }
//    }
//}

//Exercise 4
//Declare 5 arrays with 5 elements in them:
//▹ With words
//▹ With decimal values
//▹ With characters from keyboard
//▹ With true/false values
//▹ With arrays, each holding 2 whole numbers

//using System;

//string[] stringArray = new string[4];
//stringArray[0] = "Car";
//stringArray[1] = "Ice cream";
//stringArray[2] = "Eli";
//stringArray[3] = "Kalina";

//double[] doubleArray = new double[4];
//doubleArray[0] = 2.5;
//doubleArray[1] = 5.5;
//doubleArray[2] = 10.1;
//doubleArray[3] = 6.2;

//char[] charArray = new char[3];
//charArray[0] = 'a';
//charArray[1] = 'b';
//charArray[2] = 'c';

//bool[] boolArray = new bool[2];
//boolArray[0] = true;
//boolArray[1] = false;

//int[,] multiDimensionalArray2 = { { 12, 23, 35 }, { 45, 50, 62 } };
//foreach (var item in multiDimensionalArray2)
//{
//    Console.WriteLine(item);
//}

//Exercise 5

//Declare a new array of integers with 5 elements
//● Initialize the array elements with values from input
//● Sum all the values and print the result in the console

//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        int[] sumOfNumbers = new int[5];
//        int sum = 0;

//        for (int i = 0; i < sumOfNumbers.Length; i++)
//        {
//            int userInputForNum = int.Parse(Console.ReadLine());
//            sum += userInputForNum;

//        }
//        Console.WriteLine($"The result is: {sum}");
//    }

//}

//Exercise 6
//● Create an array with names
//● Give an option to the user to enter a name from the keyboard
//● After entering the name put it in the array
//● Ask the user if they want to enter another name(Y / N)
//● Do the same process over and over until the user enters N
//● Print all the names after user enters N




string[] arrayWithNames = new string[0];

var pressKeyN = "n";
var pressKeyY = "y";


while (true)
{
    Console.WriteLine("Enter name:");
    var enterName = Console.ReadLine();
    arrayWithNames = arrayWithNames.Append(enterName).ToArray();
    bool quit = false;

    while (!quit)
    {
        Console.WriteLine("Please enter from keybord to continue Y or N to Stop this APP");
        var keyInput = Console.ReadLine();

        if (keyInput == pressKeyY.ToLower())
        {
            Console.WriteLine("Continue...");
            break;
        }

        else if (keyInput == pressKeyN.ToLower())
        {
            Console.WriteLine("Stop App");
            quit = true;
            
        }
        else
        {
            Console.WriteLine("Enter valid key:");
        }
    }
    
    if (quit)
    {
        break;
    }
}

foreach (var name in arrayWithNames)
{
    Console.WriteLine(name);

}