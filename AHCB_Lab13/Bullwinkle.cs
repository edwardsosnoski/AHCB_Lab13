using System;
namespace AHCB_Lab13
{
    public class Bullwinkle : Player
    {
        public Bullwinkle()
        {
            Name = "Bullwinkle";
        }

        public override Roshambo GenerateRoshambo()
        {
            int r = new Random().Next(1, 3);
            return (Roshambo)r;
        }
    }
}