using System;

namespace Logger.Proxy
{
    public class LoggingProxy<T>
    {
        public T CreateInstance(Func<T> createWrapper)
        {
            return createWrapper();
        }
    }
}
