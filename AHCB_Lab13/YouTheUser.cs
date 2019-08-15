using System;
namespace AHCB_Lab13
{
    public class YouTheUser : Player
    {
        public YouTheUser()
        {
            Console.WriteLine("Please enter your name");
            Name = Console.ReadLine();
        }

        public override Roshambo generateRoshambo()
        {
            Roshambo userInput = new Roshambo();
            Validator validator = new Validator();
            bool validateInput;
            Console.WriteLine("Enter rock, paper, or scissors:");

            do
            {
                validateInput = validator.ValidateChoice(Console.ReadLine(), out Roshambo result);

                if (validateInput)
                {
                    userInput = result;
                    Console.WriteLine("That choice was correct.");
                }
                else
                {
                    Console.WriteLine("Invalid entry, try again.");
                }

            } while (!validateInput);
            
            return userInput;
        }
    }
}
