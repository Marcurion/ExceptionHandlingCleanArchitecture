using System.Runtime.Serialization;

namespace dnet_exception_handling.Application.Exceptions.Infrastructure
{
    public class SqlSaveException : Exception
    {
        public SqlSaveException()
        {
        }

        protected SqlSaveException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public SqlSaveException(string? message) : base(message)
        {
        }

        public SqlSaveException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
