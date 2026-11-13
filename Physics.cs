namespace PlatformerGame
{
    public class Physics
    {
        public void ApplyGravity(Player player)
        {
            // Проста гравітація
            if (player.IsJumping)
            {
                player.Y++;
                if (player.Y >= 10) // "земля"
                {
                    player.Y = 10;
                    player.IsJumping = false;
                }
            }
        }

        public bool CheckCollision(Player player, Platform platform)
        {
            return player.X >= platform.X &&
                   player.X <= platform.X + platform.Width &&
                   player.Y == platform.Y - 1;
        }
    }
}
