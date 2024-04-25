using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace dnet_exception_handling.Infrastructure.Exceptions
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
