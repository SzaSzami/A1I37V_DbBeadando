using System;
using System.Runtime.Serialization;

namespace PresentsWinForm.Models.Records
{
    [Serializable]
    internal class PresentNameNotValidException : Exception
    {
        public PresentNameNotValidException()
        {
        }

        public PresentNameNotValidException(string message) : base(message)
        {
        }

        public PresentNameNotValidException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PresentNameNotValidException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}