using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Dice Game!");

        Console.Write("Enter the name of player 1: ");
        string player1 = Console.ReadLine();

        Console.Write("Enter the name of player 2: ");
        string player2 = Console.ReadLine();

        while (player1 == player2)
        {
            Console.WriteLine("The player names cannot be the same. Please enter different names.");

            Console.Write("Enter the name of player 1: ");
            player1 = Console.ReadLine();

            Console.Write("Enter the name of player 2: ");
            player2 = Console.ReadLine();
        }

        Console.Write("Enter the number of rounds (1-5): ");
        int numRounds = int.Parse(Console.ReadLine());

        while (numRounds < 1 || numRounds > 5)
        {
            Console.WriteLine("The number of rounds must be between 1 and 5. Please enter a valid number.");

            Console.Write("Enter the number of rounds (1-5): ");
            numRounds = int.Parse(Console.ReadLine());
        }

        int score1 = 0;
        int score2 = 0;

        Dice dice = new Dice();

        for (int round = 1; round <= numRounds; round++)
        {
            Console.WriteLine($"Round {round}");

            Console.Write($"{player1} rolls the dice... ");
            Thread.Sleep(2000);
            int roll1 = dice.Roll();
            Console.WriteLine($"rolled a {roll1}");

            Console.Write($"{player2} rolls the dice... ");
            Thread.Sleep(2000);
            int roll2 = dice.Roll();
            Console.WriteLine($"rolled a {roll2}");

            if (roll1 > roll2)
            {
                Console.WriteLine($"{player1} wins the round!");
                score1++;
            }
            else if (roll2 > roll1)
            {
                Console.WriteLine($"{player2} wins the round!");
                score2++;
            }
            else
            {
                Console.WriteLine("It's a tie!");
            }
        }

        if (score1 > score2)
        {
            Console.WriteLine($"{player1} wins the game with a score of {score1}-{score2}!");
        }
        else if (score2 > score1)
        {
            Console.WriteLine($"{player2} wins the game with a score of {score2}-{score1}!");
        }
        else
        {
            Console.WriteLine("The game is tied!");
            Console.WriteLine("Playing sudden death...");

            while (score1 == score2)
            {
                Console.WriteLine("Rolling the dice...");

                Console.Write($"{player1} rolls the dice... ");
                int roll1 = dice.Roll();
                Console.WriteLine($"rolled a {roll1}");

                Console.Write($"{player2} rolls the dice... ");
                int roll2 = dice.Roll();
                Console.WriteLine($"rolled a {roll2}");

                if (roll1 > roll2)
                {
                    Console.WriteLine($"{player1} wins the game with a score of {++score1}-{score2}!");
                }
                else if (roll2 > roll1)
                {
                    Console.WriteLine($"{player2} wins the game with a score of {score1}-{++score2}!");
                }
                else
                {
                    Console.WriteLine("It's a tie! Rolling again...");
                }
            }
        }
    }
}