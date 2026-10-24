namespace SimpleFactoryToAbstract
{
    internal class Water : CondimentDecorator
    {
        public Water(Beverage beverage) : base(beverage) { }

        public override string Description => beverage.Description + ", Water";

        public override double Cost()
        {
            return beverage.Cost() + 0.10;
        }
    }
}
