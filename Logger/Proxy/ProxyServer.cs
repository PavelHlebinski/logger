using Logger.Interfases;
using System;

namespace Logger.Proxy
{
    public class GetType : IObject
    {
        public void GetObjectType<T>(T a) => Console.WriteLine("Type: " + typeof(T));
    }

    public class ProxyServer : IObject
    {
        private readonly IObject _object;
        private readonly ILogger _logger;

        public ProxyServer(IObject obj, ILogger logger)
        {
            _object = obj;
            _logger = logger;
        }

        public void GetObjectType<T>(T obj)
        {
            _object.GetObjectType(obj);
            _logger.Info("Value: " + obj);
        }
    }
}
