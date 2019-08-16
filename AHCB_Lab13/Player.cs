using System;
namespace AHCB_Lab13
{
    public abstract class Player
    {
        public string Name { get; set; }
        public virtual Roshambo Roshambo { get; set; }

        public abstract Roshambo GenerateRoshambo();
    }
}