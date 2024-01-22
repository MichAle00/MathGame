
namespace MathGame
{
    internal class Menu
    {
        GameEngine gameEngine = new();
        internal void ShowMenu(string name, DateTime date) 
        {
            bool gameOn = true;

            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Hello {name}. It's {date}. This is your math game. That's great that your working on improving yourself\n");
            Console.WriteLine("Press any key to show menu");
            Console.ReadLine();

            do
            {
                Console.WriteLine(@$"What game would you like to play today? Choose from the options below:
                V - View previous games
                A - Addition
                S - Substraction
                M - Multiplication
                D - Division
                Q - Quit the program");
                Console.WriteLine("----------------------------------");

                string? gameSelected = Console.ReadLine();

                string? diff;

                switch (gameSelected.Trim().ToLower())
                {
                    case "a":
                        diff = DifficultyMenu();
                        gameEngine.AdditionGame("Addition game", diff.Trim().ToLower());
                        break;
                    case "s":
                        diff = DifficultyMenu();
                        gameEngine.SubtractionGame("Subtraction game", diff.Trim().ToLower());
                        break;
                    case "m":
                        diff = DifficultyMenu();
                        gameEngine.MultiplicationGame("Multiplication game", diff.Trim().ToLower());
                        break;
                    case "d":
                        diff = DifficultyMenu();
                        gameEngine.DivisionGame("Division game", diff.Trim().ToLower());
                        break;
                    case "v":
                        Helpers.GetGames();
                        break;
                    case "q":
                        Console.WriteLine("Goodbye");
                        gameOn = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        Environment.Exit(1);
                        break;
                }
            } while (gameOn);
        }

        private string DifficultyMenu()
        {
            Console.WriteLine(@"Choose your difficulty:
                E - Easy
                R - Regular
                H - Hard");

            string? diff = Helpers.GetDifficulty();
            return diff;
        }
    }
}
