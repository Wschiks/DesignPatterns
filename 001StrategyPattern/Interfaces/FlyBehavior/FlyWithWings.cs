using StrategyPattern.Interfaces.FlyBehavior;

namespace StrategyPattern.QuackBehaviors
{
    internal class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I’m flying using my wings!");
        }
    }
}