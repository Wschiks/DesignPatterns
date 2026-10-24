namespace SimpleFactoryToAbstract
{
    internal abstract class CoffeeStore
    {
        public Beverage OrderCoffee(CoffeeType type)
        {
            Beverage coffee = CreateCoffee(type);

            Console.WriteLine("Making a " + type);
            return coffee;
        }

        protected abstract Beverage CreateCoffee(CoffeeType type);
    }
}
