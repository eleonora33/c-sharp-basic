var userScore = 0;
var computerScore = 0;

while (true)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine(@$"Menu choose option:
1) Play 
2) Stats  
3) Exit");
    Console.ResetColor();

    var option = 0;
    var menu = int.TryParse(Console.ReadLine(), out option);

    if (option == 1)
    {
        Console.WriteLine(@$"Start to play and choose from option:
1) Rock
2) Paper
3) Scissors");

        var userInput = Console.ReadLine().ToLower();

        string computerInput = GetRandomOption();
        Console.WriteLine($"You choose {userInput}, computer choose {computerInput}");

        string result = GameWinner(userInput, computerInput);
        Console.WriteLine(result);

        if (result.StartsWith("You"))
        {
            userScore++;
        }
        else if (result.StartsWith("Computer"))
        {
            computerScore++;
        }
        continue;
    }
    else if (option == 2)
    {
        ShowStats();
        continue;
    }
    else
    {
        Console.WriteLine("Exit game");
        break;
    }
}

static string GetRandomOption()
{
    Random random = new Random();
    int randomInt = random.Next(0, 3);
    switch (randomInt)
    {
        case 0:
            return "rock";
        case 1:
            return "paper";
        default:
            return "scissors";
    }
}

static string GameWinner(string userInput, string computerInput)
{
    if (userInput == computerInput)
    {
        return "It`s tie!";
    }
    else if ((userInput == "rock" && computerInput == "scissors") ||
            (userInput == "paper" && computerInput == "rock") ||
            (userInput == "scissors" && computerInput == "paper"))
    {
        return "You Win!";
    }
    else
    {
        return "Computer Wins!";
    }
}

void ShowStats()
{
    Console.WriteLine($"You have won {userScore} times.");
    Console.WriteLine($"The computer has won {computerScore} times.");

    int totalGames = userScore + computerScore;
    double winPercentage = (double)userScore / totalGames * 100;
    double lossPercentage = (double)computerScore / totalGames * 100;
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Your win percentage is {winPercentage:N2}%.");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Your loss percentage is {lossPercentage:N2}%.");
    Console.ResetColor();
}







