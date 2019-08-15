using System;

namespace AHCB_Lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            RoshamboApp thisGame = new RoshamboApp();
            YouTheUser thisUser = new YouTheUser();
            Roshambo thisChoice = new Roshambo();
            Bullwinkle testBullwinkle = new Bullwinkle();
            Rocky testRocky = new Rocky();

            thisChoice = thisUser.generateRoshambo();
            thisUser.Roshambo = thisChoice;

            string opponent = thisGame.Opponent();

            Console.WriteLine(testBullwinkle.generateRoshambo());
            Console.WriteLine(testRocky.generateRoshambo());
        }
    }
}
