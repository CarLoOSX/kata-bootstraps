namespace Kata.Advanced
{
    public class GameService : IGameService
    {
        private IRepository<Game> _gameRepository;

        public GameService()
        {
        }

        public void Roll(int pins)
        {

        }

        public int Score(int gameId)
        {
           _gameRepository.Get(1);
        }

        public void Initialize(int frames)
        {
            var id = _game = new Game(frames);

            _gameRepository.Add(game);
        }
    }
}