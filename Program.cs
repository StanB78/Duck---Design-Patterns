using StrategyPattern.Ducks;
using StrategyPattern.Interfaces.FlyBehavior;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MallardDuck mallard = new MallardDuck();
            mallard.Display();
            mallard.PerformQuack();
            mallard.PerformFly();

            Console.WriteLine();

            RobotDuck robot = new RobotDuck();
            robot.Display();
            robot.PerformQuack();
            robot.PerformFly();
            robot.PerformSwim();

            Console.WriteLine();


            RedheadDuck redhead = new RedheadDuck();
            redhead.Display();
            redhead.PerformQuack();
            redhead.PerformFly();

            Console.WriteLine();

            DecoyDuck decoy = new DecoyDuck();
            decoy.Display();
            decoy.PerformQuack();
            decoy.PerformFly();

            Console.WriteLine();

            RubberDuck rubber = new RubberDuck();
            rubber.Display();
            rubber.PerformQuack();
            rubber.PerformFly();


        }
    }
}