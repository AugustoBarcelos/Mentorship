
namespace HangmanGame.Classes
{
    public class Difficulty 
    {
        public void SetTries(int difficulty, out int tries)
        {
            tries = -1;
            switch (difficulty)
            {
                case 1:
                    tries = 7;
                    break;
                case 2:
                    tries = 6;
                    break;
                case 3:
                    tries = 5;
                    break;
                default:
                    Console.WriteLine("Invalid difficulty level.");
                    break;
            }
        }
    }
}
