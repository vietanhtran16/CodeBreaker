using System;
using CodeBreaker;

namespace CodeBreakerGame
{
    public static class GameConsole
    {
        static void Main()
        {
            PlayGame();
            
        }

        private static void PlayGame()
        {
            var code = new CodeGenerator();
            var codeChecker = new CodeChecker();
            var colourMapper = new ColourMapper();
            var randomCode = code.Create();
            var guess = "";
            const string response = "The mark was: ";

            Console.WriteLine("Welcome to Code Breaker!");
            while (guess != "stop")
            {
                Console.WriteLine("Please insert your guess (e.g \"r,g,y,c\"): ");
                guess = Console.ReadLine();
                if (guess == "stop") return;

                try
                {
                    var convertedGuess = colourMapper.Map(guess);
                    var mark = codeChecker.CheckGuess(randomCode, convertedGuess);
                    if (mark == "bbbb")
                    {
                        Console.WriteLine("You have won the game!");
                        Console.ReadKey();
                        return;
                    }
                    Console.WriteLine(response + mark + Environment.NewLine);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message + Environment.NewLine);
                }
            }
            Console.ReadKey();
        }
    }
}
