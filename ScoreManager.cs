namespace PlatformerGame
{
    public class ScoreManager
    {
        public int Score { get; private set; } = 0;

        public void AddScore(int points)
        {
            Score += points;
        }

        public void Reset()
        {
            Score = 0;
        }
    }
}
