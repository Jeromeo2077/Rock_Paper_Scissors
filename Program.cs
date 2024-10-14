internal class Program
{
  private static void Main()
  {
    Console.WriteLine("Welcome to Rock, Paper, and Scissors!!!");
    Console.WriteLine();
    string userHand = GetUserHand();
    string computerHand = GetComputerHand();

    Console.WriteLine($"You chose: {userHand}");
    Console.WriteLine($"Computer chose: {computerHand}");
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
    Random random = new Random();
    int computerHand = random.Next(1, 4);

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

