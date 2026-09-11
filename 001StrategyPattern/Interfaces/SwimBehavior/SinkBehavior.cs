using StrategyPattern.Interfaces.SwimBehavior;

namespace StrategyPattern.SwimBehavior
{
    internal class SinkBehavior : ISwimBehavior
    {
        public void Swim()
        {
            Console.WriteLine("I’m sinking...");
        }
    }
}