//Task1

using Homework.CSharp.Basic._4.Class;
using System;
using System.Xml.Linq;

Human person = new Human();
Console.WriteLine("Enter First Name:");
person.FirstName = Console.ReadLine();
Console.WriteLine("Enter Last Name:");
person.LastName = Console.ReadLine();
Console.WriteLine("Enter your age:");
person.Age = int.Parse(Console.ReadLine());

Console.WriteLine(person.GetPersonStats());

//Task2

Dog dog = new Dog();
Console.WriteLine("Enter the name of your dog:");
dog.Name = Console.ReadLine();
Console.WriteLine("Enter the race of your dog:");
dog.Race = Console.ReadLine();
Console.WriteLine("Enter the color of your dog:");
dog.Color = Console.ReadLine();

Console.WriteLine($"{dog.Name} with {dog.Color} color from race {dog.Race} is now:");
Console.WriteLine("******************************************************");
Console.WriteLine("Enter options 1,2 or 3 to see what the dog does in the moment");

int dogApp;
bool chooseOption = int.TryParse(Console.ReadLine(), out dogApp);

if (dogApp == 1)
{
    string optionOne = dog.Eat();
    Console.WriteLine(optionOne);
}
else if (dogApp == 2)
{
    string optionTwo = dog.Play();
    Console.WriteLine(optionTwo);
}
else if (dogApp == 3)
{
    string optionThree = dog.ChaseTail();
    Console.WriteLine(optionThree);
}
else
{
    Console.Write("Cooming soon...");
}

//Task3

Student[] students = new Student[5];
students[0] = new Student("Eli", "SEDC", "G1");
students[1] = new Student("Tose", "SEDC", "G2");
students[2] = new Student("Kalina", "SEDC", "G3");
students[3] = new Student("Marjan", "SEDC", "G4");
students[4] = new Student("Vlado", "SEDC", "G5");

Console.WriteLine("Search Academy by Student Name:");
string name = Console.ReadLine();
bool found = false;

foreach (Student student in students)
{
    if (student.Name.ToLower() == name)
    {
        Console.WriteLine($"Name:{student.Name}, Academy:{student.Academy},Group:{student.Group}");
        found = true;
        break;
    }

}

if (!found)
{
    Console.WriteLine($"The student {name} does not study at the academy");
}
















