using StrategyPattern.Interfaces.SwimBehavior;

namespace StrategyPattern.SwimBehavior
{
    internal class FloatBehavior : ISwimBehavior
    {
        public void Swim()
        {
            Console.WriteLine("I’m floating!");
        }
    }
}