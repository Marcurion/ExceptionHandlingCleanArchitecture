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
            try
            {
                _repository.SaveAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new DataChangeException("When we modified some business data things went south.", e);
            }
            
        }

    }
}
