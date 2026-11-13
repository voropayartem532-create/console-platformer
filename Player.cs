namespace PlatformerGame
{
    public class Player
    {
        public int X { get; set; } = 5;
        public int Y { get; set; } = 10;
        public int Health { get; set; } = 3;
        public bool IsJumping { get; set; } = false;

        public void MoveLeft()
        {
            if (X > 0) X--;
        }

        public void MoveRight()
        {
            X++;
        }

        public void Jump()
        {
            if (!IsJumping)
            {
                IsJumping = true;
                Y--;
            }
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health < 0) Health = 0;
        }
    }
}
