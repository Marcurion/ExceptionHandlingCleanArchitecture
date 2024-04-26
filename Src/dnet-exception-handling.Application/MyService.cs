using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dnet_exception_handling.Application.Exceptions;
using dnet_exception_handling.Domain.Interfaces;

namespace dnet_exception_handling.Application
{
    public class MyService
    {
        private IRepository<object> _repository;

        public MyService(IRepository<object> repository)
        {
            _repository = repository;
        }

        public void ChangeSomeData()
        {
            if (false) // Let's say we check if we have the data to begin with
            {
                throw new DataNotFoundException("The requested data was not available");
            }

            try
            {
                _repository.SaveAsync();
            }
            // Exception is re-contextualized for application layer, the exception is named from a use-case perspective
            // We still don't know the exact exception type since we do not see the infrastructure layer in clean architecture
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new DataChangeException("When we modified some business data things went south.", e);
            }

            
        }

    }
}
