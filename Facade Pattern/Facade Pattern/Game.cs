namespace GameApp
{
    public class Game
    {
        private readonly GraphicsSystem graphics = new GraphicsSystem();
        private readonly AudioSystem audio = new AudioSystem();
        private readonly SaveSystem saveSystem = new SaveSystem();
        private readonly NetworkService network = new NetworkService();
        private readonly GameEngine gameEngine = new GameEngine();

        public void Start()
        {
            graphics.Initialize();
            graphics.SetResolution(1920, 1080);

            audio.Initialize();
            audio.SetVolume(70);

            saveSystem.LoadSettings();
            saveSystem.LoadPlayer();

            network.Connect();
            network.Login();

            gameEngine.LoadWorld();
            gameEngine.Start();
        }

        public void Stop()
        {
            saveSystem.SaveSettings();
            saveSystem.SavePlayer();

            network.Disconnect();
            network.Logout();

            gameEngine.UnloadWorld();
            gameEngine.Stop();
        }
    }
}