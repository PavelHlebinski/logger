namespace Logger
{
    public static class LoggerFactory
    {
        public static ILogger GetLogger() => new ConsoleLogger();

        public static ILogger GetLogger(string path, string name) => new FileLogger(path, name);
    }
}
