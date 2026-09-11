using StrategyPattern.Ducks;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>
            {
                new MallardDuck(),
                new RedheadDuck(),
                new RubberDuck(),
                new DecoyDuck(),
                new RobotDuck()
            };

            foreach (var duck in ducks)
            {
                duck.Display();
                duck.PerformQuack();
                duck.PerformFly();
                duck.PerformSwim();
                Console.WriteLine(" ");
            }
        }
    }
}