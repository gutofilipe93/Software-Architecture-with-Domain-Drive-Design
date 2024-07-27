using IEnvolveSystem.Infra.Data.EFCore.Contexts;
using IEvolveSystem.Domain.Entities;
using IEvolveSystem.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnvolveSystem.Infra.Data.EFCore.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppEFCoreDbContext _context;

        public CustomerRepository(AppEFCoreDbContext context)
        {
            _context = context;
        }

        public Customer Create(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return customer;
        }

        public IEnumerable<Customer> GetAll()
        {
            return _context.Customers.ToList();
        }

        public Customer GetById(int id)
        {
            var customer = _context.Customers.Find(id);
            return customer;
        }

        public Customer Update(Customer customer)
        {
            _context.Customers.Update(customer);
            _context.SaveChanges();
            return customer;
        }
    }
}
