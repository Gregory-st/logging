using System;

namespace DataBaseWorker.Exceptions
{
    public class NotFoundFileConfigConnectionException : NotFoundException
    {
        public NotFoundFileConfigConnectionException() { }
        public NotFoundFileConfigConnectionException(string message) : base(Prompt + message) { }
    }
}
