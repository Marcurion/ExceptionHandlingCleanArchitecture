using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dnet_exception_handling.Domain.Interfaces;

namespace dnet_exception_handling.Infrastructure.Repositories
{
    internal class MyRepository : IRepository<object>
{
    public void SaveAsync()
    {
        throw new NotImplementedException();
    }
}
}
