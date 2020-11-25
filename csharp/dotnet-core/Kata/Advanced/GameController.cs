namespace Kata.Advanced
{
    public class GameController
    {
        private readonly IGameService _gameService;

        public GameController(IGameService gameservice)
        {
            _gameService = gameservice;
        }

        public void NewGame(int frames)
        {
            _gameService.Initialize(frames);
        }

        public void Roll(int pins)
        {
            _gameService.Roll(pins);
        }
    }
}