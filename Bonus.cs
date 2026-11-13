namespace PlatformerGame
{
    public class Bonus
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Type { get; set; } // "health", "score", "speed"
        public bool IsCollected { get; set; } = false;

        public Bonus(int x, int y, string type)
        {
            X = x;
            Y = y;
            Type = type;
        }
    }
}
