namespace SimpleFactoryToAbstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PizzaStore pizzaStore = new NYPizzaStore();
            Pizza pizza = pizzaStore.OrderPizza("cheese");
            Console.WriteLine("Ethan ordered " + pizza.Name);
            
            PizzaStore pizzaStore1 = new CaliforniaPizzaStore();
            Pizza pizza1 = pizzaStore1.OrderPizza("cheese");
            Console.WriteLine("Ethan ordered " + pizza1.Name);

            CoffeeStore coffeeStore = new EspressoWinkel();
            Beverage coffee = coffeeStore.OrderCoffee(CoffeeType.CaffeLatte);
            Console.WriteLine(coffee.Description + " " + coffee.Cost());
        }
    }
}