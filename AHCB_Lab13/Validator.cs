using System;
namespace AHCB_Lab13
{
    public class Validator
    {
        public bool ValidateOpponent(string userInput, out string result)
        {
            if (userInput.Equals("R", StringComparison.OrdinalIgnoreCase) ||
                userInput.Equals("B", StringComparison.OrdinalIgnoreCase))
            {
                result = userInput;
                return true;
            }
            else
            {
                result = userInput;
                return false;
            }
        }

        public bool ValidateChoice(string userInput, out Roshambo result)
        {
            return Enum.TryParse(userInput, out result);
        }
    }
}
