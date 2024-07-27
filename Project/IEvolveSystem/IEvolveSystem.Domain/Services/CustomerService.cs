using IEvolveSystem.Domain.Entities;
using IEvolveSystem.Domain.Interfaces.Repositories;
using IEvolveSystem.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEvolveSystem.Domain.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public Customer Create(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void ChangeCustomerType(int customerId)
        {
            var customer = _customerRepository.GetById(customerId);
            if ((DateTime.Now.Year - Convert.ToDateTime(customer.RegistrationDate).Year) > 1)
            {
                customer.CustomerType = "silver";
                _customerRepository.Update(customer);
            }
            if ((DateTime.Now.Year - Convert.ToDateTime(customer.RegistrationDate).Year) > 3)
            {
                customer.CustomerType = "gold";
                _customerRepository.Update(customer);
            }            
        }
    }
}
