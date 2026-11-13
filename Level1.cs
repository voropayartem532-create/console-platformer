namespace PlatformerGame
{
    public class Level1 : Level
    {
        public override void Load()
        {
            Platforms.Clear();
            Platforms.Add(new Platform(0, 12, 20));
            Platforms.Add(new Platform(25, 10, 8));
            Platforms.Add(new Platform(40, 8, 10));

            Coins.Add(new Coin(27, 9));
            Coins.Add(new Coin(42, 7));

            Enemies.Add(new Enemy(30, 11));
        }
    }
}
