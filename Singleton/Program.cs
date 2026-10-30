namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChocolateBoiler boiler1 = ChocolateBoiler.GetInstance();
            ChocolateBoiler boiler2 = ChocolateBoiler.GetInstance();

            if (boiler1 == boiler2)
            {
                Console.WriteLine("Er is maar 1 boiler.");
            }
        }
    }
}