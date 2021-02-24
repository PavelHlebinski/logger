using System;
using System.Collections.Generic;
using System.Text;

namespace Logger 
{
    class ConsoleLogger : ILogger
    {
        public void Error(string message) => Console.WriteLine($"Error: {message}");

        public void Error(Exception ex) => Console.WriteLine($"Error: {ex.Message} \n {ex.StackTrace}");

        public void Warning(string message) => Console.WriteLine($"Warn: {message}");

        public void Info(string message) => Console.WriteLine($"Info: {message}");       
    }
}
