//## Task 1
//*Create a class Human
//*Add properties: FirstName, LastName, Age
//* Create a method called GetPersonDetails that returns the full name of the human as well as their age
//* Create an object human by asking the user to fill the required information (take first name, last name and age from user input)
//*Call the GetPersonDetails method and print the result in the console after the object is created

using CSharp.Basic.Homework._5.Class;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection.Metadata;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml.Linq;
using System;
using System.Net.Security;

Console.WriteLine("Please enter your name:");
string name = Console.ReadLine();

Console.WriteLine("Please enter your Last Name:");
string lastName = Console.ReadLine();

Console.WriteLine("Please enter your age:");
int age = int.Parse(Console.ReadLine());

Human person = new()
{
    FirstName = name,
    LastName = lastName,
    Age = age
};


var onePerson = person.GetPersonDetails();
Console.WriteLine(onePerson);

//## Task 2
//*Make a class Driver. Add properties: Name, Level
//* Make a class Car. Add properties: Model, Speed and Driver
//* Make a method of the Car class called :
//CalculateSpeed() that takes a driver object and calculates the skill multiplied by the speed of the car and return it as a result.
//* Make a method RaceCars() that will get two Car objects that will determine which car will win and print the result in the console.
//* Make 4 car objects and 4 driver objects.
//* Ask the user to select a two cars and two drivers for the cars.Add the drivers to the cars and call the RaceCars() methods
//* Test Data:
//  *Choose a car no.1: 
//    *Hyundai
//    * Mazda
//    * Ferrari
//    * Porsche
//  * Choose Driver:
//*Bob
//* Greg
//* Jill
//* Anne
//* Choose a car no.2:
//    *Hyundai
//    * Mazda
//    * Ferrari
//    * Porsche
//  * Choose Driver:
//*Bob
//* Greg
//* Jill
//* Anne
//* Expected Output:
//*Car no. 2 was faster.

//> **BONUS 1 * *: If a user chooses option one for the first car, eliminate that option when the user picks car two. 

//> **BONUS 2**: Make the Output message say what was the model of the car that won,
//what speed was it going and which driver was driving it.

//> **BONUS 3**: Implement a Race Again Feature where you ask the user if he wants to race again and repeat the racing function.

while (true)
{
    Console.WriteLine("Enter Y if you want to Continue or Enter N if you want to Quit the game");
    string continueOrQuitGameUserInput = Console.ReadLine().ToLower();

    if (continueOrQuitGameUserInput == "n")
    {
        Console.WriteLine("You Quit Game.Come back again...");
        break;

    }
    else if (continueOrQuitGameUserInput == "y")
    {
        Console.WriteLine("========================================");
        Console.WriteLine("Select Number 1: first car from the list(1,2,3 or 4:)");
        Console.WriteLine("========================================");

        Console.WriteLine($"1.Hyundai");
        Console.WriteLine("2.Mazda");
        Console.WriteLine("3.Ferrari");
        Console.WriteLine("4.Porsche");

        int chooseCarNo1 = int.Parse(Console.ReadLine());

        Console.WriteLine("========================================");
        Console.WriteLine("Select Number 1: and first driver from the list");
        Console.WriteLine("========================================");

        Console.WriteLine("1.Bob");
        Console.WriteLine("2.Greg");
        Console.WriteLine("3.Jill");
        Console.WriteLine("4.Anne");

        int chooseDriverNo1 = int.Parse(Console.ReadLine());

        Console.WriteLine("========================================");
        Console.WriteLine("Select Number 2: second car from the list ");
        Console.WriteLine("========================================");

        Console.WriteLine("1.Hyundai");
        Console.WriteLine("2.Mazda");
        Console.WriteLine("3.Ferrari");
        Console.WriteLine("4.Porsche");

        int chooseCarNo2 = int.Parse(Console.ReadLine());

        Console.WriteLine("========================================");
        Console.WriteLine("Select Number 2: second driver from the list");
        Console.WriteLine("========================================");

        Console.WriteLine("1.Bob");
        Console.WriteLine("2.Greg");
        Console.WriteLine("3.Jill");
        Console.WriteLine("4.Anne");

        int chooseDriverNo2 = int.Parse(Console.ReadLine());
        Console.WriteLine("========================================");

        Driver bob = new Driver { Name = "Bob", Level = 1 };
        Driver greg = new Driver { Name = "Greg", Level = 2 };
        Driver jill = new Driver { Name = "Jill", Level = 3 };
        Driver anne = new Driver { Name = "Anne", Level = 4 };

        Car hyundai = new Car { Model = "Hyundai", Speed = 220, Driver = bob };
        Car mazda = new Car { Model = "Mazda", Speed = 210, Driver = greg };
        Car ferrari = new Car { Model = "Ferrari", Speed = 230, Driver = jill };
        Car porsche = new Car { Model = "Porsche", Speed = 250, Driver = anne };

        Car? selectedCarOne = null;

        switch (chooseCarNo1)
        {
            case 1:
                selectedCarOne = hyundai; break;
            case 2:
                selectedCarOne = mazda; break;
            case 3:
                selectedCarOne = ferrari; break;
            case 4:
                selectedCarOne = porsche; break;
            default:
                Console.WriteLine("Invalid option");
                break;
        }

        switch (chooseDriverNo1)
        {
            case 1:
                selectedCarOne.Driver = bob; break;
            case 2:
                selectedCarOne.Driver = greg; break;
            case 3:
                selectedCarOne.Driver = jill; break;
            case 4:
                selectedCarOne.Driver = anne; break;
            default:
                Console.WriteLine("invalid option");
                break;
        }

        Car? selectedCarTwo = null;

        switch (chooseCarNo2)
        {
            case 1:
                selectedCarTwo = hyundai; break;
            case 2:
                selectedCarTwo = mazda; break;
            case 3:
                selectedCarTwo = ferrari; break;
            case 4:
                selectedCarTwo = porsche; break;
            default:
                Console.WriteLine("Invalid option");
                break;
        }

        switch (chooseDriverNo2)
        {
            case 1:
                selectedCarTwo.Driver = bob; break;
            case 2:
                selectedCarTwo.Driver = greg; break;
            case 3:
                selectedCarTwo.Driver = jill; break;
            case 4:
                selectedCarTwo.Driver = anne; break;
            default:
                Console.WriteLine("Invalid option");
                break;
        }

        Game game = new Game();
        game.RaceCars(selectedCarOne, selectedCarTwo);

        continue;
    }
    else
    {
        Console.WriteLine("Wrong Option.Try again");

    }
}



