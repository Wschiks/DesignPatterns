namespace SimpleFactoryToAbstract
{
    internal class SteamedMilk : CondimentDecorator
    {
        public SteamedMilk(Beverage beverage) : base(beverage) { }

        public override string Description => beverage.Description + ", Steamed Milk";

        public override double Cost()
        {
            return beverage.Cost() + 0.25;
        }
    }
}
