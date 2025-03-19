using System;
using System.Runtime.Serialization;

namespace DataBaseWorker.Exceptions
{
    public class NotFoundFilePersonWithIdException : NotFoundException
    {
        protected static readonly string PromptPerson = "пользователь с указанным идентификатором "; 
        public NotFoundFilePersonWithIdException() : base(PromptPerson)
        {           
        }

        public NotFoundFilePersonWithIdException(string message) : base(PromptPerson + message)
        {
        }

        public NotFoundFilePersonWithIdException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NotFoundFilePersonWithIdException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
