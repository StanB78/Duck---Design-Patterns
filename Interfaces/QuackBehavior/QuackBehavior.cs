using System;

namespace StrategyPattern.Interfaces.QuackBehavior
{
    internal interface QuackBehavior
    {
        void Quack();
    }

    internal class RegularQuack : QuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("quack");
        }
    }

    internal class MuteQuack : QuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("<<Silence>>");
        }
    }

    internal class Squeak : QuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}