using System;
namespace AHCB_Lab13
{
    public class RoshamboApp
    {
        public string Opponent()
        {
            Console.WriteLine("Would you like to play against Rocky or Bullwinkle (R/B)?");
            Validator validator = new Validator();
            bool validateInput;
            string opponent = "";

            do
            {
                validateInput = validator.ValidateOpponent(Console.ReadLine(), out string result);

                if (validateInput)
                {
                    opponent = result;
                    Console.WriteLine("That opponent was corrrect.");
                }
                else
                {
                    Console.WriteLine("Invalid entry, try again.");
                }
            } while (!validateInput);

            return opponent;
        }
    }
}
