using System;
using System.Runtime.Serialization;

namespace Presents.Models.Records
{
    [Serializable]
    internal class IdTooLongException : Exception
    {
        public IdTooLongException()
        {
        }

        public IdTooLongException(string message) : base(message)
        {
        }

        public IdTooLongException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected IdTooLongException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}