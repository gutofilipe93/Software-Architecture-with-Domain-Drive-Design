using IEvolveSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEvolveSystem.Domain.Interfaces.Services
{
    public interface ICustomerService
    {
        Customer Create(Customer customer);
        void ChangeCustomerType(int customerId);
    }
}
