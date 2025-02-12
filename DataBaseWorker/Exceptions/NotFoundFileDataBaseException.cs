using System;

namespace DataBaseWorker.Exceptions
{
    public class NotFoundFileDataBaseException : Exception
    {
        public NotFoundFileDataBaseException() { }
        public NotFoundFileDataBaseException(string message) : base(message) { }
    }
}
