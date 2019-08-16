using System;
namespace AHCB_Lab13
{
    public class Validator
    {
        public bool ValidateOpponent(string userInput, out Player result)
        {
            if (userInput.Equals("R", StringComparison.OrdinalIgnoreCase))
            {
                result = new Rocky();
                return true;
            }
            else if (userInput.Equals("B", StringComparison.OrdinalIgnoreCase))
            {
                result = new Bullwinkle();
                return true;
            }
            else
            {
                result = new Bullwinkle(); //this is never used, it's just to prevent an error
                return false;
            }
        }

        public bool ValidateChoice(string userInput, out Roshambo result)
        {
            return Enum.TryParse(userInput, out result);
        }

        public bool ValidatePlayAgain(string userInput, out string result)
        {
            result = userInput;

            if (userInput.Equals("Y", StringComparison.OrdinalIgnoreCase) ||
                userInput.Equals("N", StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            return false;
        }
    }
}
