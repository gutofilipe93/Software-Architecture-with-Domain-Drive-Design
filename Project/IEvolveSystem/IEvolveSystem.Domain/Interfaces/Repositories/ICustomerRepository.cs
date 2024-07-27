using IEvolveSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEvolveSystem.Domain.Interfaces.Repositories
{
    public interface ICustomerRepository
    {
        Customer Create(Customer customer);
        Customer GetById(int id);
        IEnumerable<Customer> GetAll();
        Customer Update (Customer customer);
    }
}
