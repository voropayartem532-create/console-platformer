namespace PlatformerGame
{
    public class Enemy
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Direction { get; set; } = 1;

        public Enemy(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Move()
        {
            X += Direction;

            // Простий патруль
            if (X > 50 || X < 0)
            {
                Direction *= -1;
            }
        }
    }
}
