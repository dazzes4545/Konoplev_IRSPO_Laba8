namespace CustomNamespace
{
    public class System
    {
        public string Version { get; set; } = "1.0";

        public void PrintVersion()
        {
            global::System.Console.WriteLine($"Версия системы: {Version}");
        }
    }
}