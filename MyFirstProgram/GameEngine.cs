using MyFirstProgram.Models;

namespace MyFirstProgram
{
    internal class GameEngine
    {
        internal void AdditionGame(string message)
        {
            Console.WriteLine(message);

            var random = new Random();
            int firstNumber;
            int secondNumber;
            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);
                int answer = firstNumber + secondNumber;

                Console.WriteLine($"What is {firstNumber} + {secondNumber}?");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == answer)
                {
                    Console.WriteLine("Correct! Press any key for the next question");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Incorrect! Press any key for the next question");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    Console.WriteLine("Game Over!");
                    Console.WriteLine($"Your score is {score}");

                }
            }

            Helpers.AddToHistory(score, GameType.Addition);
        }

        internal void SubtractionGame(string message)
        {
            Console.WriteLine(message);

            var random = new Random();
            int firstNumber;
            int secondNumber;
            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                int answer = firstNumber - secondNumber;

                Console.WriteLine($"What is {firstNumber} - {secondNumber}?");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == answer)
                {
                    Console.WriteLine("Correct! Press any key for the next question");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Incorrect! Press any key for the next question");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    Console.WriteLine("Game Over!");
                    Console.WriteLine($"Your score is {score}. Press any key to return to main menu");
                    Console.ReadLine();
                    Helpers.AddToHistory(score, GameType.Subtraction);

                }
            }

            Helpers.AddToHistory(score, GameType.Subtraction);
        }

        internal void MultiplicationGame(string message)
        {
            Console.WriteLine(message);

            var random = new Random();
            int firstNumber;
            int secondNumber;
            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);
                int answer = firstNumber * secondNumber;

                Console.WriteLine($"What is {firstNumber} * {secondNumber}?");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == answer)
                {
                    Console.WriteLine("Correct! Press any key for the next question");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Incorrect! Press any key for the next question");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    Console.WriteLine("Game Over!");
                    Console.WriteLine($"Your score is {score}");

                }
            }

            Helpers.AddToHistory(score, GameType.Multiplication);
        }

        internal void DivisionGame(string message)
        {
            int score = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);
                var divisionNumbers = Helpers.GetDivisionNumbers();
                int firstNumber = divisionNumbers[0];
                int secondNumber = divisionNumbers[1];
                int answer = firstNumber / secondNumber;

                Console.WriteLine($"What is {firstNumber} / {secondNumber}?");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == answer)
                {
                    Console.WriteLine("Correct! Press any key for the next question");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Incorrect! Press any key for the next question");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    Console.WriteLine("Game Over!");
                    Console.WriteLine($"Your score is {score}");

                }
            }

            Helpers.AddToHistory(score, GameType.Division);
        }
    }
}
