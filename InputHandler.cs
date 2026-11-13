using System;

namespace PlatformerGame
{
    public class InputHandler
    {
        public void HandleInput(Player player)
        {
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.A:
                    case ConsoleKey.LeftArrow:
                        player.MoveLeft();
                        break;

                    case ConsoleKey.D:
                    case ConsoleKey.RightArrow:
                        player.MoveRight();
                        break;

                    case ConsoleKey.Spacebar:
                    case ConsoleKey.W:
                    case ConsoleKey.UpArrow:
                        player.Jump();
                        break;

                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
