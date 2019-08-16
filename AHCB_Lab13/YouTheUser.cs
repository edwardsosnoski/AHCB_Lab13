using System;
namespace AHCB_Lab13
{
    public class YouTheUser : Player
    {
        private const string Value = "Please enter your name:";

        public YouTheUser()
        {
            Console.WriteLine(Value);
            Name = Console.ReadLine();
        }

        public override Roshambo GenerateRoshambo()
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
