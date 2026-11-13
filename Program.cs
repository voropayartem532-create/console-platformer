using System;

namespace PlatformerGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Гра платформер";
            Console.CursorVisible = false;

            Game game = new Game();
            game.Run();
        }
    }
}
