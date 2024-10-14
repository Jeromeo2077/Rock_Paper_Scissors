internal class Program
{
  private static void Main()
  {
    Console.WriteLine("Welcome to Rock, Paper, and Scissors!!!");
    Console.WriteLine("Would you like to play a game? :P");
    Console.WriteLine();
    string userHand = GetUserHand();
    string computerHand = GetComputerHand();

    Console.WriteLine($"You chose: {userHand}");
    Console.WriteLine($"Computer chose: {computerHand}");

    if (userHand == computerHand)
    {
      Console.WriteLine("It's a tie!");
    }
    else if (userHand == "Rock" && computerHand == "Scissors" || userHand == "Paper" && computerHand == "Rock" || userHand == "Scissors" && computerHand == "Paper")
    {
      Console.WriteLine("You win!");
    }
    else
    {
      Console.WriteLine("Computer wins!");
    }
  }

  static string GetUserHand()
  {
    Console.WriteLine("Please enter your choice: ");
    Console.WriteLine("1. Rock");
    Console.WriteLine("2. Paper");
    Console.WriteLine("3. Scissors");

    string? userHand = Console.ReadLine();

    if (userHand == "1")
    {
      userHand = "Rock";
      return userHand;
    }
    else if (userHand == "2")
    {
      userHand = "Paper";
      return userHand;
    }
    else if (userHand == "3")
    {
      userHand = "Scissors";
      return userHand;
    }
    else  // If the user enters an invalid input
    {
      Console.WriteLine();
      Console.WriteLine("Invalid input. Please try again.");
      Console.WriteLine();
      return GetUserHand();
    }
  }

  static string GetComputerHand()
  {
    int computerHand = new Random().Next(1, 4);

    if (computerHand == 1)
    {
      return "Rock";
    }
    else if (computerHand == 2)
    {
      return "Paper";
    }
    else
    {
      return "Scissors";
    }
  }
}

