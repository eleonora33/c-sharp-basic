using SEDC.CSharp.Basic.Homework._6.Class;
using System;

Customer[] customers = new Customer[]
{
    new Customer("Eli", "Gjorgjieva",new Card(1111222233334444, 100)),
    new Customer("Toso", "Todorovski",new Card(432143214325, 1000)),
    new Customer("Vlado","Gjorgjiev",new Card(125454448451, 950)),
    new Customer("Slavica","Todorovska",new Card(54565145456, 120)),
    new Customer("Kalina","Gjorgjieva",new Card(454564456455, 2000)),
};

foreach (Customer customer in customers)
{
    customer.GetCustomerInfo();
}

Console.WriteLine();
Console.WriteLine("Welcome to the ATM app");
Console.WriteLine("Please Enter your card cardNo:For Example 1234-1234-1234-1234");

string input = Console.ReadLine();

string numberString = input.Replace("-", "");

long cardNo;

if (long.TryParse(numberString, out cardNo))
{
    Console.WriteLine("Your ATM card cardNo is: " + cardNo);
}
else
{
    Console.WriteLine("Invalid input");
}

Console.WriteLine("Enter you pin:");
int pinInput = int.Parse(Console.ReadLine());

Customer loggedCustomer = null;

foreach (var customer in customers)
{
    if (customer.Card.Number == cardNo && customer.Card.GetCardPin() == pinInput)
    {
        loggedCustomer = customer;
        Console.WriteLine($"Welcome: {loggedCustomer.Firstname} {loggedCustomer.Lastname}!");
        break;
    }
    else if (customer.Card.Number != cardNo || customer.Card.GetCardPin() != pinInput)
    {

        Console.WriteLine("Wrong card and pin.Try again!");
        return;

    }
    else
    {
        Console.WriteLine("Something went wrong come back after 1 hour");
        break;
    }
}

while (loggedCustomer != null)
{
    Console.Write("What would you like to do:");
    Console.WriteLine("Choose option 1,2 or 3");
    Console.WriteLine("1) Check Balance");
    Console.WriteLine("2) Cash Withdrawal");
    Console.WriteLine("3) Cash Deposit");
    Console.WriteLine("4) Logout");

    _ = int.TryParse(Console.ReadLine(), out int userInputForOption);

    if (userInputForOption == 1)
    {
        Console.WriteLine("1) Check Balance");
        Console.WriteLine($"Your balance is: {loggedCustomer.Card.Balance} ");
    }
    else if (userInputForOption == 2)
    {
        Console.WriteLine("Enter amount to withdraw:");

        int userInputWithdrawel = int.Parse(Console.ReadLine());

        if (loggedCustomer.Card.Balance < userInputWithdrawel)
        {
            Console.WriteLine("You don`t have that amount on bank account");
        }
        else
        {
            loggedCustomer.Card.Balance -= userInputWithdrawel;
            Console.WriteLine($"Your balance is:{loggedCustomer.Card.Balance}");
        }
    }
    else if(userInputForOption == 3)
    {
        Console.WriteLine("Enter amount of deposit that you want to add:");
        int userInputDeposit = int.Parse(Console.ReadLine());
        loggedCustomer.Card.Balance += userInputDeposit;
        Console.WriteLine($"Your balance is:{loggedCustomer.Card.Balance}");
    }
    else if(userInputForOption == 4)
    {
        Logout();
        Console.WriteLine("You have logged out.Thank you for using our bank!");
    }
    else
    {
        Console.WriteLine("Invalid input. Please try again!");
    }
}

void Logout()
{
    loggedCustomer = null;
}











