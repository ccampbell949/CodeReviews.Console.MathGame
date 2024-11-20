namespace MyFirstProgram
{
    internal class Menu
    {
        GameEngine gameEngine = new GameEngine();
        internal void ShowMenu(string name, DateTime date)
        {
            Console.Clear();
            Console.WriteLine("--------------------");
            Console.WriteLine($"Hello {name}. It's {date}. This is your maths game.\n");
            Console.WriteLine("Press any key to show menu");
            Console.ReadKey();

            var isGameOn = true;

            do
            {
                Console.Clear();
                Console.WriteLine(@$"What game would you like to play today? Please choose from the options below:
V - View previous scores
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit the program");

                Console.WriteLine("------------------------");

                var gameSelected = Console.ReadLine();

                switch (gameSelected.Trim().ToLower())
                {
                    case "v":
                        Helpers.PrintGames("Previous scores:");
                        break;
                    case "a":
                        gameEngine.AdditionGame("Addition Game");
                        break;
                    case "s":
                        gameEngine.SubtractionGame("Subtraction Game");
                        break;
                    case "m":
                        gameEngine.MultiplicationGame("Multiplication Game");
                        break;
                    case "d":
                        gameEngine.DivisionGame("Division Game");
                        break;
                    case "q":
                        Console.WriteLine("Goodbye");
                        isGameOn = false;
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Invalid selection. Please try again");
                        break;
                }
            }
            while (isGameOn);
        }
    }
}
