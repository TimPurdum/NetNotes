using System;
using System.Runtime.Serialization;

namespace NetNotes.Business.Elements
{
    [Serializable]
    internal class UnrecognizedTimeSignatureException : Exception
    {
        public UnrecognizedTimeSignatureException()
        {
        }

        public UnrecognizedTimeSignatureException(string message) : base(message)
        {
        }

        public UnrecognizedTimeSignatureException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected UnrecognizedTimeSignatureException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}