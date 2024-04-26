using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dnet_exception_handling.Domain.Interfaces;
using dnet_exception_handling.Infrastructure.Exceptions;

namespace dnet_exception_handling.Infrastructure.Repositories
{
    internal class MyRepository : IRepository<object>
{
    public void SaveAsync()
    {
        if (false) // Let's assume we test if we are connected to the rest of the backend here
        {
            throw new ConnectionOfflineException("We have no intranet connection");
        }

        try
        {
            // Something went wrong
            throw new NotImplementedException();
        }
        catch (Exception e)
        {
            // Exception reflects the technicalities of the infrastructure layer, exception is named from a technology perspective
            throw new SqlSaveException("Storing changes in Sql DB was not possible", e);
        }

    }
}
}
