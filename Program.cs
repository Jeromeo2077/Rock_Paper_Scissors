internal class Program
{
  private static void Main()
  {
    Console.WriteLine("Welcome to Rock, Paper, and Scissors!!!");
    Console.WriteLine();
    string userHand = GetUserHand();
  }

  static string GetUserHand()
  {
    Console.WriteLine("Please enter your choice: ");
    Console.WriteLine("1. Rock");
    Console.WriteLine("2. Paper");
    Console.WriteLine("3. Scissors");

    string userHand = Console.ReadLine();

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
      Console.WriteLine("Invalid input. Please try again.");
      return GetUserHand();
    }
  }
}

