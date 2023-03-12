//## Task 1

//Console.WriteLine("Enter a string:");
//string input = Console.ReadLine();

//if (input.Length >= 5)
//{
//    string lastFiveChars = input.Substring(input.Length - 5);
//    Console.WriteLine("The last 5 characters of the string are: {0}", lastFiveChars);
//}
//else
//{
//    Console.WriteLine("The input string is too short to have 5 characters.");
//}

//## Task 2

//Console.WriteLine("Enter a sentence:");

//string inputSentence = Console.ReadLine();
//string[] words = inputSentence.Split(' ');

//Console.WriteLine("Words in sentence:");

//foreach (string word in words)
//{
//    Console.WriteLine(word);
//}

//## Task 3

//Console.WriteLine("Enter number:");

//int ifParsedValue;
//bool parsingSuccsess = int.TryParse(Console.ReadLine(), out ifParsedValue);

//Console.WriteLine("The sum of the digits in the number is :");

//if (parsingSuccsess)
//{

//    Console.WriteLine(SumDigits(ifParsedValue));
//}
//else
//{
//    Console.WriteLine("Something wen`t wrong check your WI-FI");
//}

//int SumDigits(int number)
//{
//string num = Convert.ToString(number);
//int sum = 0;
//    for (int i = 0; i < num.Length; i++)
//    {
//        sum += Convert.ToInt32(num.Substring(i,1));

//    }
//    return sum; 
//}

//## Task 4
//*Make a method called AgeCalculator
//* The method will have one input parameter, your birthday date
//* The method should return your age
//* Show the age of a user after he inputs a date

//> Note: take into consideration if the birthday is today, after or before today

Console.WriteLine("Enter your birthday (in dd/mm/yyyy format):");
var userInput = Console.ReadLine();
DateTime birthDay;

if (DateTime.TryParse(userInput, out birthDay))
{

    var agePerson = AgeCalculator(birthDay);
    Console.WriteLine(agePerson);
}
DateTime currentDay = DateTime.Today;
Console.WriteLine(currentDay);
int AgeCalculator(DateTime birthDay)
{
    DateTime currentDay = DateTime.Today;
    int age = currentDay.Year - birthDay.Year;

    if (birthDay > currentDay.AddYears(-age))
    {
        age--;
    }
    return age;
}
