using System;
namespace AHCB_Lab13
{
    public class Rocky : Player
    {
        public Rocky()
        {
            Name = "Rocky";
        }

        public override Roshambo GenerateRoshambo()
        {
            Roshambo = Roshambo.rock;
            return Roshambo;
        }
    }
}
