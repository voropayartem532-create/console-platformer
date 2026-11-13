using System;
using System.Threading;

namespace PlatformerGame
{
    public class Game
    {
        private Player player;
        private InputHandler input;
        private UI ui;
        private ScoreManager scoreManager;
        private Physics physics;
        private Level currentLevel;
        private bool isRunning = true;

        public Game()
        {
            player = new Player();
            input = new InputHandler();
            ui = new UI();
            scoreManager = new ScoreManager();
            physics = new Physics();
            currentLevel = new Level1();
            currentLevel.Load();
        }

        public void Run()
        {
            ShowMenu();

            while (isRunning)
            {
                input.HandleInput(player);
                Update();
                Render();
                Thread.Sleep(80);
            }
        }

        private void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("===== ГРА ПЛАТФОРМЕР =====");
            Console.WriteLine();
            Console.WriteLine("1. Почати гру");
            Console.WriteLine("2. Вихід");
            Console.WriteLine();
            Console.Write("Виберіть: ");

            string choice = Console.ReadLine();

            if (choice == "2")
            {
                isRunning = false;
                return;
            }

            Console.Clear();
        }

        private void Update()
        {
            physics.ApplyGravity(player);

            // Колізії з платформами
            foreach (var platform in currentLevel.Platforms)
            {
                if (physics.CheckCollision(player, platform))
                {
                    player.IsJumping = false;
                    player.Y = platform.Y - 1;
                }
            }

            // Збір монеток
            foreach (var coin in currentLevel.Coins)
            {
                if (!coin.IsCollected && coin.X == player.X && coin.Y == player.Y)
                {
                    coin.IsCollected = true;
                    scoreManager.AddScore(10);
                }
            }

            // Вороги
            foreach (var enemy in currentLevel.Enemies)
            {
                enemy.Move();

                if (enemy.X == player.X && enemy.Y == player.Y)
                {
                    player.TakeDamage(1);

                    if (player.Health <= 0)
                    {
                        ui.ShowLose();
                        isRunning = false;
                    }
                }
            }

            // Перевірка перемоги (зібрав усі монетки)
            bool allCoinsCollected = true;
            foreach (var coin in currentLevel.Coins)
            {
                if (!coin.IsCollected)
                {
                    allCoinsCollected = false;
                    break;
                }
            }

            if (allCoinsCollected)
            {
                ui.ShowWin();
                isRunning = false;
            }
        }

        private void Render()
        {
            Console.Clear();
            ui.Draw(scoreManager.Score, player.Health);

            // Малюємо платформи
            foreach (var platform in currentLevel.Platforms)
            {
                for (int i = 0; i < platform.Width; i++)
                {
                    SafeWrite(platform.X + i, platform.Y, '=');
                }
            }

            // Малюємо монетки
            foreach (var coin in currentLevel.Coins)
            {
                if (!coin.IsCollected)
                {
                    SafeWrite(coin.X, coin.Y, 'O');
                }
            }

            // Малюємо ворогів
            foreach (var enemy in currentLevel.Enemies)
            {
                SafeWrite(enemy.X, enemy.Y, 'X');
            }

            // Малюємо гравця
            SafeWrite(player.X, player.Y, '@');
        }

        private void SafeWrite(int x, int y, char symbol)
        {
            if (x >= 0 && x < Console.WindowWidth && y >= 0 && y < Console.WindowHeight)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(symbol);
            }
        }
    }
}
