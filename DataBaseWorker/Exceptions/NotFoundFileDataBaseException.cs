using System;

namespace DataBaseWorker.Exceptions
{
    public class NotFoundFileDataBaseException : NotFoundException
    {
        public NotFoundFileDataBaseException() { }
        public NotFoundFileDataBaseException(string message) : base(Prompt + message) { }
    }
}
