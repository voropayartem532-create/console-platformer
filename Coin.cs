namespace PlatformerGame
{
    public class Coin
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool IsCollected { get; set; } = false;

        public Coin(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
