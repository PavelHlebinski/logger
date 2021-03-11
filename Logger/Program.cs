using Logger.Interfases;
using Logger.Proxy;
using System;

namespace Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            var loggingProxy = new LoggingProxy<IObject>();
            var obj = loggingProxy.CreateInstance(() => new ProxyServer(new GetType(), LoggerFactory.GetLogger()));

            obj.GetObjectType(10);
            obj.GetObjectType('s');
            obj.GetObjectType("asdasd");
            Console.ReadKey();
        }
    }
}
