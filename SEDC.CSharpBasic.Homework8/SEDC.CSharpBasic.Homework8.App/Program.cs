using SEDC.CSharpBasic.Homework8.App.Class;
using System.Collections;

Queue<int> numbers = new Queue<int>();

while (true)
{
    Console.WriteLine("Please enter a number:");

    int number;
    bool userInputSuccess = int.TryParse(Console.ReadLine(), out number);

    if (userInputSuccess)
    {
        numbers.Enqueue(number);
    }
    else
    {
        Console.WriteLine("Invalid input");
        break;
    }

    Console.WriteLine("Please enter Y if you want to continue, or N to exit the program");
    string input = Console.ReadLine();

    if (input.ToLower() == "y")
    {
        continue;
    }
    else if (input.ToLower() == "n")
    {
        break;
    }
    else
    {
        Console.WriteLine("invalid input");
        break;
    }

}

Console.WriteLine("Result inputs from user:");

foreach (var userInputNumbers in numbers)
{
    Console.WriteLine(userInputNumbers);
}

List<int> num = new List<int>() { 2, 89, 4, 8, 6, 5, 7, 10, 9, 11 };

var squares = num.Select(x => x * x).ToList();

foreach (var square in squares)
{
    Console.WriteLine(square);
}

List<Animal> animals = new List<Animal>()
{
    new Animal("Koko","red",3, Gender.Male),
    new Animal("Buco", "green", 5, Gender.Male),
    new Animal("Momo", "black", 10, Gender.Male),
    new Animal("Cezar", "brown", 6, Gender.Male),
    new Animal("Sika","brown", 15, Gender.Female),
    new Animal("Masha", "grey", 14, Gender.Female),
    new Animal("Alisa","white", 8, Gender.Female),
    new Animal("Coco", "white", 8, Gender.Female),
};

var animalsNames = animals.Where(a => a.Name.StartsWith('A')).Select(a => a.Name).ToList();

Console.WriteLine("Animals with the first letter starting with char A:");

foreach (var firtLetterA in animalsNames)
{
    Console.WriteLine(firtLetterA);
}

var animalsAge = animals.Where(a => a.Age >= 5).Select(a => a.Age).ToList();

Console.WriteLine("Animals with more then 5 years old or equal:");

foreach (var ageOfAnimals in animalsAge)
{
    Console.WriteLine(ageOfAnimals);
}

Console.WriteLine("All male and brown animals:");

var maleAndBrownAnimals = animals.Where(a => a.Gender.Equals(Gender.Male) && a.Color == "brown").Select(a => a.Name).ToList();

foreach (var male in maleAndBrownAnimals)
{
    Console.WriteLine(male);
}

Console.WriteLine("Result of the first animal whose name is longer than 10 characters:");

var longNameOfAnimal = animals.FirstOrDefault(a => a.Name.Length >= 10);

if (longNameOfAnimal != null)
{
    Console.WriteLine(longNameOfAnimal.Name);
}
else
{
    Console.WriteLine("There is no name longer than 10 characters in the list");
}





