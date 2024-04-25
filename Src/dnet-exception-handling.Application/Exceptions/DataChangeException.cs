using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace dnet_exception_handling.Application.Exceptions
{
    internal class DataChangeException : ApplicationException
    {
        public DataChangeException()
        {
        }

        protected DataChangeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public DataChangeException(string? message) : base(message)
        {
        }

        public DataChangeException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
