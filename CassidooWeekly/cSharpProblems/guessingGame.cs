using System;
public class Program
{
    public static void Main()
    {
        GuessingGame();
    }

    public static void GuessingGame()
    {

        var rand = new Random();
        int num = rand.Next(1, 21);
        int userGuess = 0;
        Console.WriteLine("Guess the number between 1 and 20 :)");

        while (userGuess != num)
        {
            int number;
            bool success = int.TryParse(Console.ReadLine(), out number);

            if (success)
            {
                userGuess = number;
                if (userGuess > num)
                {
                    Console.WriteLine("Uh oh, too high, try again");
                }
                else if (userGuess < num)
                {
                    Console.WriteLine("Ooooooo, too low, try again");
                }
            }
            else
            {
                Console.WriteLine("Please try again with only a number");
            }
        }
        Console.WriteLine("Yay! You won! :)");
    }
}