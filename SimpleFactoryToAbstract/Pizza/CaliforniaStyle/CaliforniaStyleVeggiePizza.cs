namespace SimpleFactoryToAbstract
{
    internal class CaliforniaStyleVeggiePizza : Pizza
    {
        public CaliforniaStyleVeggiePizza()
        {
            name = "California Style Veggie Pizza";
            dough = "Thin Dough";
            sauce = "Red Sauce";
            toppings.Add("Cheese");
            toppings.Add("Veggies");
        }
    }
}
