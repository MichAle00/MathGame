
using MathGame.Models;

namespace MathGame
{
    internal class GameEngine
    {
        internal void AdditionGame(string message, string difficulty)
        {
            int number1, number2;
            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);
                number1 = Helpers.SetDifficulty(difficulty);
                number2 = Helpers.SetDifficulty(difficulty);

                Console.WriteLine($"{number1} + {number2}");
                var result = Console.ReadLine();
                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == (number1 + number2))
                {
                    Console.WriteLine("Your answer was correct. Type any key to get the next question");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"Your answer was wrong. Type any key to get the next question");
                    Console.ReadLine();

                }

                if (i == 4)
                {
                    Console.WriteLine($"Game over. Your final score was {score}/5. Press any key to go back to the menu");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, GameType.Addition, Helpers.GetDifficultyLevel(difficulty));
        }

        internal void SubtractionGame(string message, string difficulty)
        {
            int number1, number2;
            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                number1 = Helpers.SetDifficulty(difficulty);
                number2 = Helpers.SetDifficulty(difficulty);

                Console.WriteLine($"{number1} - {number2}");
                var result = Console.ReadLine();
                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == (number1 - number2))
                {
                    Console.WriteLine("Your answer was correct. Type any key to get the next question");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"Your answer was wrong. Type any key to get the next question");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    Console.WriteLine($"Game over. Your final score was {score}/5. Press any key to go back to the menu");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, GameType.Subtraction, DifficultyLevel.Easy);
        }

        internal void MultiplicationGame(string message, string difficulty)
        {
            int number1, number2;
            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                number1 = Helpers.SetDifficulty(difficulty);
                number2 = Helpers.SetDifficulty(difficulty);

                Console.WriteLine($"{number1} * {number2}");
                var result = Console.ReadLine();
                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == (number1 * number2))
                {
                    Console.WriteLine("Your answer was correct. Type any key to get the next question");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"Your answer was wrong. Type any key to get the next question");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    Console.WriteLine($"Game over. Your final score was {score}/5. Press any key to go back to the menu");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, GameType.Multiplication, DifficultyLevel.Easy);
        }

        internal void DivisionGame(string message, string difficulty)
        {
            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                int[] numbers = Helpers.GetDivisionNumbers(difficulty);
                Console.WriteLine($"{numbers[0]} / {numbers[1]}");
                var result = Console.ReadLine();
                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == (numbers[0] / numbers[1]))
                {
                    Console.WriteLine("Your answer was correct. Type any key to get the next question");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"Your answer was wrong. Type any key to get the next question");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    Console.WriteLine($"Game over. Your final score was {score}/5. Press any key to go back to the menu");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, GameType.Division, DifficultyLevel.Easy);
        }

    }
}
