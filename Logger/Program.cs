namespace Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            //var logger = LoggerFactory.GetConsoleLogger();
            var logger = LoggerFactory.GetFileLogger();
            logger.Error("sdfs");
        }
    }
}
