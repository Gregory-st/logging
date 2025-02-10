using System;
using System.Runtime.Serialization;

namespace DataBaseWorker.Exceptions
{
    public class NotFoundDictionaryException : Exception
    {
        public NotFoundDictionaryException()
        {
        }

        public NotFoundDictionaryException(string message) : base(message)
        {
        }

        public NotFoundDictionaryException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NotFoundDictionaryException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
