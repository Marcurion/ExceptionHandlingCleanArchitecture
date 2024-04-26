using System.Runtime.Serialization;

namespace dnet_exception_handling.Application.Exceptions.Infrastructure
{
    public class ConnectionOfflineException : Exception
    {
        public ConnectionOfflineException()
        {
        }

        protected ConnectionOfflineException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public ConnectionOfflineException(string? message) : base(message)
        {
        }

        public ConnectionOfflineException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
