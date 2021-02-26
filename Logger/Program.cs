using System;

namespace Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = LoggerFactory.GetLogger(Environment.CurrentDirectory + "\\..\\..\\..\\", "log.txt");
            logger.Error("sdfs");
        }
    }
}
