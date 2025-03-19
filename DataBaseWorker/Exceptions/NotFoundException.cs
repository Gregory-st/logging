using System;
using System.Runtime.Serialization;

namespace DataBaseWorker.Exceptions
{
    public class NotFoundException : Exception
    {
        protected static readonly string Prompt = "Не удалось найти ";
        public NotFoundException() : base(Prompt)
        {
        }

        public NotFoundException(string message) : base(Prompt + message)
        {
        }

        public NotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
