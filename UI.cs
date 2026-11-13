using System;

namespace PlatformerGame
{
    public class UI
    {
        public void Draw(int score, int lives)
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine($"Очки: {score}   Життя: {lives}");
            Console.WriteLine("----------------------------------------");
        }

        public void ShowWin()
        {
            Console.Clear();
            Console.WriteLine("===== ПЕРЕМОГА! =====");
            Console.WriteLine("Ти пройшов усі рівні!");
        }

        public void ShowLose()
        {
            Console.Clear();
            Console.WriteLine("===== ГРА ЗАКІНЧЕНА =====");
            Console.WriteLine("Спробуй ще раз!");
        }
    }
}
