using System;
using System.Runtime.Serialization;

namespace NetNotes.Business
{
    [Serializable]
    internal class UnrecognizedPatternException : Exception
    {
        public UnrecognizedPatternException()
        {
        }

        public UnrecognizedPatternException(string message) : base(message)
        {
        }

        public UnrecognizedPatternException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected UnrecognizedPatternException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}