using System;
namespace AHCB_Lab13
{
    public class RoshamboApp
    {
        public void PlayGame()
        {
            var player = new YouTheUser();
            var opponent = Opponent();
            bool playAgainValid;
            bool playAgain;
            var validator = new Validator();

            do
            {
                player.Roshambo = player.GenerateRoshambo();
                opponent.Roshambo = opponent.GenerateRoshambo();

                Console.WriteLine($"{player.Name}: {player.Roshambo}");
                Console.WriteLine($"{opponent.Name}: {opponent.Roshambo}");

                if (player.Roshambo == opponent.Roshambo)
                {
                    Console.WriteLine("It's a draw!");
                }
                else if ((player.Roshambo.Equals(Roshambo.paper) && opponent.Roshambo.Equals(Roshambo.rock)) ||
                    (player.Roshambo.Equals(Roshambo.scissors) && opponent.Roshambo.Equals(Roshambo.paper)) ||
                    (player.Roshambo.Equals(Roshambo.rock) && opponent.Roshambo.Equals(Roshambo.scissors)))
                {
                    Console.WriteLine($"{player.Name} wins!");
                }
                else
                {
                    Console.WriteLine($"{opponent.Name} wins!");
                }

                do
                {
                    Console.WriteLine("Would you like to play again (Y/N)?");

                    if (validator.ValidatePlayAgain(Console.ReadLine(), out string playAgainInput))
                    {
                        playAgainValid = true;
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid entry.");
                        playAgainValid = false;
                    }

                    playAgain = playAgainInput.Equals("Y", StringComparison.OrdinalIgnoreCase);

                } while (!playAgainValid);
            } while (playAgain);
        }

        public Player Opponent()
        {
            Console.WriteLine("Would you like to play against Rocky or Bullwinkle (R/B)?");
            Validator validator = new Validator();
            bool validateInput;

            do
            {
                string userInput = Console.ReadLine();
                validateInput = validator.ValidateOpponent(userInput, out Player result);

                if (validateInput)
                {
                    return result;
                }
                Console.WriteLine("Invalid entry, try again.");
            } while (!validateInput);

            return new Bullwinkle(); //this never happens, it's just to prevent an error
        }
    }
}
