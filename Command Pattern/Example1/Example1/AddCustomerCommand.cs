using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    public class AddCustomerCommand : ICommand
    {
        private readonly CustomerService _service;

        public AddCustomerCommand(CustomerService service)
        {
            _service = service;
        }

        public void Execute()
            => _service.AddCustomer();
    }
}
