using Microsoft.VisualBasic;
using HangmanGame.Classes;
class Program
{
    static void Main()
    {
        string csvFilePath = "words.csv";
        string[] words = CsvReader.ReadWordsFromCsv(csvFilePath);

        //This part will be changed by a method for make the rattle
        Random rnd = new Random();
        string word = words[rnd.Next(words.Length)];

        Difficulty difficulty = new Difficulty();
        int level;
        do
        {
            Console.WriteLine("Enter difficulty level (1 for easy, 2 for medium, 3 for hard):");
        } while (!int.TryParse(Console.ReadLine(), out level) || level < 1 || level > 3);
        int tries;
        difficulty.SetTries(level, out tries);
        Console.WriteLine($"Number of tries for level {level}: {tries}");




        char[] hidden = Enumerable.Repeat('_', word.Length).ToArray();

        while (tries > 0 && hidden.Contains('_'))
        {
            Console.WriteLine("Word: \n" + string.Join("", hidden));
            Console.WriteLine("Tries Left:" + tries);
            Console.WriteLine("Guess a letter: ");

            char letter = Console.ReadLine()[0];

            bool found = false;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == letter)
                {
                    hidden[i] = letter;
                    found = true;
                }
            }

            if (!found)
            {
                tries--;
            }

            if (tries == 0)
            {
                Console.WriteLine("You lost. The word was " + word);
            }
        }

        if (tries > 0)
        {
            Console.WriteLine("You won! The word was " + word);
        }
    }
}