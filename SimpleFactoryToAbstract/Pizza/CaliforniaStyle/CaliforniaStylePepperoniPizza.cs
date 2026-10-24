namespace SimpleFactoryToAbstract
{
    internal class CaliforniaStylePepperoniPizza : Pizza
    {
        public CaliforniaStylePepperoniPizza()
        {
            name = "California Style Pepperoni Pizza";
            dough = "Thin Dough";
            sauce = "Red Sauce";
            toppings.Add("Cheese");
            toppings.Add("Pepperoni");
        }
    }
}
