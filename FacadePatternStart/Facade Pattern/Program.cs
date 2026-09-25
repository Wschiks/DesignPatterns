namespace GameApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Start in dev mode? (y/n): ");
            string input = Console.ReadLine();
            bool devMode = input == "y";

            if (devMode)
            {
                Console.WriteLine("Running in DEV MODE");
            }

            Game game = new Game();
            game.Start();

            Console.Write("Stop game? (y/n): ");
            string stopInput = Console.ReadLine();
            bool stopMode = stopInput == "y";

            if (stopMode)
            {
                game.Stop();
            }
        }
    }
}