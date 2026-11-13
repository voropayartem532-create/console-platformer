namespace PlatformerGame
{
    public class Level2 : Level
    {
        public override void Load()
        {
            Platforms.Clear();
            Platforms.Add(new Platform(0, 12, 15));
            Platforms.Add(new Platform(20, 9, 6));
            Platforms.Add(new Platform(30, 6, 8));
            Platforms.Add(new Platform(45, 10, 12));

            Coins.Add(new Coin(22, 8));
            Coins.Add(new Coin(32, 5));
            Coins.Add(new Coin(48, 9));

            Enemies.Add(new Enemy(25, 11));
            Enemies.Add(new Enemy(35, 5));
        }
    }
}
