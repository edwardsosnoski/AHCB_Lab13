using System;
namespace AHCB_Lab13
{
    public class Bullwinkle : Player
    {
        public Bullwinkle()
        {
            Name = "Bullwinkle";
        }

        public override Roshambo generateRoshambo()
        {
            Random r = new Random();
            int rInt = r.Next(1, 3);
            Roshambo = (Roshambo)rInt;
            return Roshambo;
        }
    }
}