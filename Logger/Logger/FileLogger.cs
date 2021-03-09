using System;
using System.IO;

namespace Logger
{
    class FileLogger : ILogger
    {
        private readonly string FileName;

        public FileLogger(string path, string name)
        {
            FileName = Path.Combine(path, name);
        }

        public void WriteToFile(string message)
        {
            try
            {
                using var fileStream = new FileStream(FileName, FileMode.Append, FileAccess.Write);
                using var streamWriter = new StreamWriter(fileStream);
                streamWriter.WriteLine(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message} \n {ex.StackTrace}");
            }
        }

        public void Error(string message) => WriteToFile($"Error: {message}");

        public void Error(Exception ex) => WriteToFile($"Error: {ex.Message} \n {ex.StackTrace}");

        public void Warning(string message) => WriteToFile($"Warn: {message}");

        public void Info(string message) => WriteToFile($"Info: {message}");
    }
}
