namespace OnlineDiary.Utils
{
    using System;
    using System.IO;
    public class DotEnv
    {
        public static void Load(string path)
        {
            if (!File.Exists(path))
                return;
            foreach (var line in File.ReadAllLines(path))
            {
                var parts = line.Split('=', 2, StringSplitOptions.RemoveEmptyEntries);
                Console.WriteLine(parts[0], parts[1]);
                Environment.SetEnvironmentVariable(parts[0], parts[1]);
            }
        }
    }
}
