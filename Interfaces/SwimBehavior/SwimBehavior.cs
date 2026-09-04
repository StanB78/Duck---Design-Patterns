using System;

namespace StrategyPattern.Interfaces.SwimBehavior
{
    internal interface SwimBehavior
    {
        void Swim();
    }

    internal class SwimWithLegs : SwimBehavior
    {
        public void Swim()
        {
            Console.WriteLine("I'm swimming using my legs!");
        }
    }

    internal class SwimNoWay : SwimBehavior
    {
        public void Swim()
        {
            Console.WriteLine("I can't swim!");
        }
    }
}