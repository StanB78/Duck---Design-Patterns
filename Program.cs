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
            mallard.PerformSwim();

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
            redhead.PerformSwim();


            Console.WriteLine();

            DecoyDuck decoy = new DecoyDuck();
            decoy.Display();
            decoy.PerformQuack();
            decoy.PerformFly();
            decoy.PerformSwim();


            Console.WriteLine();

            RubberDuck rubber = new RubberDuck();
            rubber.Display();
            rubber.PerformQuack();
            rubber.PerformFly();
            rubber.PerformSwim();


            Console.WriteLine();


        }
    }
}