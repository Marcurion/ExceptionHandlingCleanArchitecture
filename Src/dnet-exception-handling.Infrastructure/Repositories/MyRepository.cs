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
        try
        {
            throw new NotImplementedException();
        }
        catch (Exception e)
        {
            throw new SqlSaveException("Storing changes in Sql DB was not possible", e);
        }

    }
}
}
