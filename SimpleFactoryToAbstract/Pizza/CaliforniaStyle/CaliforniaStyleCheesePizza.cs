namespace SimpleFactoryToAbstract
{
    internal class CaliforniaStyleCheesePizza : Pizza
    {
        public CaliforniaStyleCheesePizza()
        {
            name = "California Style Cheese Pizza";
            dough = "Thin Dough";
            sauce = "Red Sauce";
            toppings.Add("Cheese");
        }
    }
}
