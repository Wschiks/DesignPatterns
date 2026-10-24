namespace SimpleFactoryToAbstract
{
    internal class CaliforniaStyleClamPizza : Pizza
    {
        public CaliforniaStyleClamPizza()
        {
            name = "California Style Clam Pizza";
            dough = "Thin Dough";
            sauce = "Red Sauce";
            toppings.Add("Cheese");
            toppings.Add("Clams");
        }
    }
}
