using System.Collections.Generic;

namespace PlatformerGame
{
    public abstract class Level
    {
        public List<Platform> Platforms { get; set; } = new List<Platform>();
        public List<Enemy> Enemies { get; set; } = new List<Enemy>();
        public List<Coin> Coins { get; set; } = new List<Coin>();

        public abstract void Load();
    }
}
