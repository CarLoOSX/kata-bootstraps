namespace Kata.Advanced
{
    public interface IGameService
    {
        void Roll(int pins);

        int Score();

        void Initialize(int frames);
    }
}