using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace dnet_exception_handling.Infrastructure.Exceptions
{
    internal class ConnectionOfflineException : Exception
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
