namespace SimpleFactoryToAbstract
{
    internal class EspressoWinkel : CoffeeStore
    {
        protected override Beverage CreateCoffee(CoffeeType type)
        {
            Beverage coffee = new Espresso();

            switch (type)
            {
                case CoffeeType.Lungo:
                    coffee = new Water(coffee);
                    break;
                case CoffeeType.Macchiato:
                    coffee = new MilkFoam(coffee);
                    break;
                case CoffeeType.ConPanna:
                    coffee = new Whip(coffee);
                    break;
                case CoffeeType.Cappuccino:
                    coffee = new SteamedMilk(coffee);
                    coffee = new MilkFoam(coffee);
                    break;
                case CoffeeType.CaffeLatte:
                    coffee = new SteamedMilk(coffee);
                    coffee = new SteamedMilk(coffee);
                    coffee = new MilkFoam(coffee);
                    break;
            }

            return coffee;
        }
    }
}
