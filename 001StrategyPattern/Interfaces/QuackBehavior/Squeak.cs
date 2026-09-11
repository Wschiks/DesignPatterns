using StrategyPattern.Interfaces.QuackBehavior;

namespace StrategyPattern.QuackBehaviors
{
    internal class Squeak  : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeak");;
        }
    }
}