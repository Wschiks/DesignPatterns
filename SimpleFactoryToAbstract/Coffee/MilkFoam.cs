namespace SimpleFactoryToAbstract
{
    internal class MilkFoam : CondimentDecorator
    {
        public MilkFoam(Beverage beverage) : base(beverage) { }

        public override string Description => beverage.Description + ", Milk Foam";

        public override double Cost()
        {
            return beverage.Cost() + 0.30;
        }
    }
}
