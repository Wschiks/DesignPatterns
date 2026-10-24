namespace SimpleFactoryToAbstract
{
    internal abstract class CondimentDecorator : Beverage
    {
        protected Beverage beverage;

        protected CondimentDecorator(Beverage beverage)
        {
            this.beverage = beverage;
        }
    }
}
