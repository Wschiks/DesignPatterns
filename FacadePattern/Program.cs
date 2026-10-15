namespace FacadePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Amplifier amp = new Amplifier();
            CdPlayer cdPlayer = new CdPlayer(amp);
            DvdPlayer dvdPlayer = new DvdPlayer(amp);
            PopcornPopper popcornPopper = new PopcornPopper();
            Projector projector = new Projector();
            Screen screen = new Screen();
            TheaterLights lights = new TheaterLights();
            Tuner tuner = new Tuner(amp);

            HomeTheaterFacade homeTheater = new HomeTheaterFacade(amp, cdPlayer, dvdPlayer, popcornPopper,
                projector, screen, lights, tuner);

            homeTheater.WatchMovie("Die Hard");
            Console.WriteLine();
            homeTheater.EndMovie();
            Console.WriteLine();

            homeTheater.ListenToCd();
            Console.WriteLine();
            homeTheater.EndCd();
            Console.WriteLine();

            homeTheater.ListenToRadio();
            Console.WriteLine();
            homeTheater.EndRadio();
        }
    }
}