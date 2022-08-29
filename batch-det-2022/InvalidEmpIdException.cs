using System.Runtime.Serialization;

namespace emp
{
    [Serializable]
    internal class InvalidEmpIdException : Exception
    {
        public InvalidEmpIdException()
        {
        }

        public InvalidEmpIdException(string? message) : base(message)
        {
        }

        public InvalidEmpIdException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected InvalidEmpIdException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}