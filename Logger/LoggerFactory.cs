using System;
using System.Collections.Generic;
using System.Text;

namespace Logger
{
    public static class LoggerFactory
    {
        public static ILogger GetConsoleLogger() => new ConsoleLogger();
        public static ILogger GetFileLogger() => new FileLogger();
    }      
}
