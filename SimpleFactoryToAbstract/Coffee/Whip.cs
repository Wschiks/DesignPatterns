namespace SimpleFactoryToAbstract
{
    internal class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage) : base(beverage) { }

        public override string Description => beverage.Description + ", Whip";

        public override double Cost()
        {
            return beverage.Cost() + 0.40;
        }
    }
}
