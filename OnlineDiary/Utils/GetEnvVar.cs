namespace OnlineDiary.Utils
{
    public class GetEnvVar
    {
        public static string GetEnvString(string key)
        {
            var root = Directory.GetCurrentDirectory();
            var dotenv = Path.Combine(root, ".env");
            DotEnv.Load(dotenv);
            
            return Environment.GetEnvironmentVariable(key);
        }
    }
}
