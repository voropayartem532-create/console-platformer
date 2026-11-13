namespace PlatformerGame
{
    public class Platform
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }

        public Platform(int x, int y, int width)
        {
            X = x;
            Y = y;
            Width = width;
        }
    }
}
