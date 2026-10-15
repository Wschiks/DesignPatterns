namespace FacadePattern;

// The Facade: one simple entry point in front of the whole home theater subsystem.
internal class HomeTheaterFacade
{
    // Composition (HAS-A): the facade holds a reference to every subsystem component.
    private Amplifier _amp;
    private CdPlayer _cdPlayer;
    private DvdPlayer _dvdPlayer;
    private PopcornPopper _popcornPopper;
    private Projector _projector;
    private Screen _screen;
    private TheaterLights _lights;
    private Tuner _tuner;

    // The components are created outside and passed in (the facade does not "new" them itself).
    public HomeTheaterFacade(Amplifier amp, CdPlayer cdPlayer, DvdPlayer dvdPlayer, PopcornPopper popcornPopper,
        Projector projector, Screen screen, TheaterLights lights, Tuner tuner)
    {
        _amp = amp;
        _cdPlayer = cdPlayer;
        _dvdPlayer = dvdPlayer;
        _popcornPopper = popcornPopper;
        _projector = projector;
        _screen = screen;
        _lights = lights;
        _tuner = tuner;
    }

    // Same steps that used to be in Program.cs, now hidden behind one method.
    public void WatchMovie(string movie)
    {
        Console.WriteLine("Get ready to watch a movie...");

        Console.WriteLine("PopcornPopper: On");
        _popcornPopper.On();
        Console.WriteLine("PopcornPopper: Pop");
        _popcornPopper.Pop();

        Console.WriteLine("TheaterLights: Dim(10)");
        _lights.Dim(10);

        Console.WriteLine("Screen: Down");
        _screen.Down();

        Console.WriteLine("Projector: On");
        _projector.On();
        Console.WriteLine("Projector: SetInput(dvdPlayer)");
        _projector.SetInput(_dvdPlayer);
        Console.WriteLine("Projector: WideScreenMode");
        _projector.WideScreenMode();

        Console.WriteLine("Amplifier: On");
        _amp.On();
        Console.WriteLine("Amplifier: SetDvd(dvdPlayer)");
        _amp.SetDvd(_dvdPlayer);
        Console.WriteLine("Amplifier: SetSurroundSound");
        _amp.SetSurroundSound();
        Console.WriteLine("Amplifier: SetVolume(5)");
        _amp.SetVolume(5);

        Console.WriteLine("DvdPlayer: On");
        _dvdPlayer.On();
        Console.WriteLine($"DvdPlayer: Play(\"{movie}\")");
        _dvdPlayer.Play(movie);
    }

    // Shut everything down, roughly in reverse order of WatchMovie.
    public void EndMovie()
    {
        Console.WriteLine("Shutting movie theater down...");

        Console.WriteLine("PopcornPopper: Off");
        _popcornPopper.Off();

        Console.WriteLine("TheaterLights: On");
        _lights.On();

        Console.WriteLine("Screen: Up");
        _screen.Up();

        Console.WriteLine("Projector: Off");
        _projector.Off();

        Console.WriteLine("Amplifier: Off");
        _amp.Off();

        Console.WriteLine("DvdPlayer: Stop");
        _dvdPlayer.Stop();
        Console.WriteLine("DvdPlayer: Eject");
        _dvdPlayer.Eject();
        Console.WriteLine("DvdPlayer: Off");
        _dvdPlayer.Off();
    }

    public void ListenToCd()
    {
        Console.WriteLine("Get ready for an audiophile experience...");

        Console.WriteLine("TheaterLights: On");
        _lights.On();

        Console.WriteLine("Amplifier: On");
        _amp.On();
        Console.WriteLine("Amplifier: SetVolume(5)");
        _amp.SetVolume(5);
        Console.WriteLine("Amplifier: SetCd(cdPlayer)");
        _amp.SetCd(_cdPlayer);
        Console.WriteLine("Amplifier: SetStereoSound");
        _amp.SetStereoSound();

        Console.WriteLine("CdPlayer: On");
        _cdPlayer.On();
        Console.WriteLine("CdPlayer: Play");
        _cdPlayer.Play();
    }

    public void EndCd()
    {
        Console.WriteLine("Shutting down CD...");

        Console.WriteLine("Amplifier: Off");
        _amp.Off();

        Console.WriteLine("CdPlayer: Stop");
        _cdPlayer.Stop();
        Console.WriteLine("CdPlayer: Eject");
        _cdPlayer.Eject();
        Console.WriteLine("CdPlayer: Off");
        _cdPlayer.Off();
    }

    public void ListenToRadio()
    {
        Console.WriteLine("Tuning in the airwaves...");

        Console.WriteLine("Tuner: On");
        _tuner.On();
        Console.WriteLine("Tuner: SetFM");
        _tuner.SetFM();
        Console.WriteLine("Tuner: SetFrequency");
        _tuner.SetFrequency();

        Console.WriteLine("Amplifier: On");
        _amp.On();
        Console.WriteLine("Amplifier: SetVolume(5)");
        _amp.SetVolume(5);
        Console.WriteLine("Amplifier: SetTuner(tuner)");
        _amp.SetTuner(_tuner);
    }

    public void EndRadio()
    {
        Console.WriteLine("Shutting down the tuner...");

        Console.WriteLine("Tuner: Off");
        _tuner.Off();

        Console.WriteLine("Amplifier: Off");
        _amp.Off();
    }
}
