using System;
using System.IO;

namespace Logger
{
    class FileLogger : ILogger
    {
        private static readonly string path = Environment.CurrentDirectory + "\\..\\..\\..\\";
        private static readonly string name = "log.txt";
        private static readonly string fileName = Path.Combine(path, name);

        public void WriteToFile(string message)
        {
            using var fileStream = new FileStream(fileName, FileMode.Append, FileAccess.Write);
            using var streamWriter = new StreamWriter(fileStream);
            streamWriter.WriteLine(message);
        }

        public void Error(string message) => WriteToFile($"Error: {message}");

        public void Error(Exception ex) => WriteToFile($"Error: {ex.Message} \n {ex.StackTrace}");

        public void Warning(string message) => WriteToFile($"Warn: {message}");

        public void Info(string message) => WriteToFile($"Info: {message}");
    }
}
