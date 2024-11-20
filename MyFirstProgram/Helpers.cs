using MyFirstProgram.Models;

namespace MyFirstProgram
{
    internal class Helpers
    {
        internal static List<Game> games = new List<Game>
        {
            //new Game { Date = DateTime.Now.AddDays(1), Type = GameType.Addition, Score = 5 },
            //new Game { Date = DateTime.Now.AddDays(2), Type = GameType.Multiplication, Score = 4 },
            //new Game { Date = DateTime.Now.AddDays(3), Type = GameType.Division, Score = 4 },
            //new Game { Date = DateTime.Now.AddDays(4), Type = GameType.Subtraction, Score = 3 },
            //new Game { Date = DateTime.Now.AddDays(5), Type = GameType.Addition, Score = 1 },
            //new Game { Date = DateTime.Now.AddDays(6), Type = GameType.Multiplication, Score = 2 },
            //new Game { Date = DateTime.Now.AddDays(7), Type = GameType.Division, Score = 3 },
            //new Game { Date = DateTime.Now.AddDays(8), Type = GameType.Subtraction, Score = 4 },
            //new Game { Date = DateTime.Now.AddDays(9), Type = GameType.Addition, Score = 4 },
            //new Game { Date = DateTime.Now.AddDays(10), Type = GameType.Multiplication, Score = 1 },
            //new Game { Date = DateTime.Now.AddDays(11), Type = GameType.Subtraction, Score = 0 },
            //new Game { Date = DateTime.Now.AddDays(12), Type = GameType.Division, Score = 2 },
            //new Game { Date = DateTime.Now.AddDays(13), Type = GameType.Subtraction, Score = 5 },
        };
        internal static int[] GetDivisionNumbers()
        {
            var random = new Random();
            int firstNumber = random.Next(1, 99);
            int secondNumber = random.Next(1, 99);
            var result = new int[2];

            while (firstNumber % secondNumber != 0)
            {
                firstNumber = random.Next(1, 99);
                secondNumber = random.Next(1, 99);
            }
            result[0] = firstNumber;
            result[1] = secondNumber;

            return result;
        }

        internal static void PrintGames(string message)
        {
            var gamesToPrint = games.Where(x => x.Type == GameType.Addition);
            //var gamesToPrint = games.OrderByDescending(x => x.Date).Take(5).ToList();
            Console.Clear();
            Console.WriteLine(message);
            Console.WriteLine("------------------------");
            foreach (var game in gamesToPrint)
            {
                Console.WriteLine($"{game.Date} - {game.Type}: {game.Score}pts");
            }
            Console.WriteLine("------------------------\n");
            Console.WriteLine("Press any key to return to main menu");
            Console.ReadLine();
        }

        internal static void AddToHistory(int score, GameType gameType)
        {
            games.Add(new Game
            {
                Date = DateTime.UtcNow,
                Score = score,
                Type = gameType
            });
        }

        internal static string? ValidateResult(string result)
        {
            while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _)) //Checking if input WONT be parsed to run the loop again
            {
                Console.WriteLine("Please enter a valid number");
                result = Console.ReadLine();
            }

            return result;
        }

        internal static string GetName()
        {
            Console.WriteLine("Please type your name");
            var name = Console.ReadLine();
            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Please enter a valid name");
                name = Console.ReadLine();
            }
            return name;
        }
    }
}
