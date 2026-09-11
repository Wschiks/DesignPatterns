using StrategyPattern.Interfaces.QuackBehavior;

namespace StrategyPattern.QuackBehaviors
{
    internal class RegularQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
    
}