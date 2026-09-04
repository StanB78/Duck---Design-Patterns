using System;

namespace StrategyPattern.Interfaces.FlyBehavior
{
    internal interface FlyBehavior
    {
        void Fly();
    }

    internal class FlyWithWings : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying using my wings!");
        }
    }

    internal class FlyNoWay : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly!");
        }
    }
}