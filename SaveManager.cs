using System;
using System.IO;

namespace PlatformerGame
{
    public class SaveManager
    {
        private string filePath = "save.txt";

        public void Save(int score, int level)
        {
            File.WriteAllText(filePath, $"{score}\n{level}");
        }

        public (int score, int level) Load()
        {
            if (!File.Exists(filePath))
                return (0, 1);

            string[] data = File.ReadAllLines(filePath);
            int score = int.Parse(data[0]);
            int level = int.Parse(data[1]);
            return (score, level);
        }
    }
}
