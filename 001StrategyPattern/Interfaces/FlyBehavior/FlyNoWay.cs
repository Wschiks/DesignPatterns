using StrategyPattern.Interfaces.FlyBehavior;

namespace StrategyPattern.FlyBehaviors
{
    internal class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly");
        }
    }
}