using System;

namespace DataBaseWorker.Exceptions
{
    public class NotFoundFileConfigConnectionException : Exception
    {
        public NotFoundFileConfigConnectionException() { }
        public NotFoundFileConfigConnectionException(string message) : base(message) { }
    }
}
