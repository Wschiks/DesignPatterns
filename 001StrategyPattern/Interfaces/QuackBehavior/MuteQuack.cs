using StrategyPattern.Interfaces.QuackBehavior;

namespace StrategyPattern.QuackBehaviors
{
    internal class MuteQuack  : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("<< Silence >>");
        }
    }
}