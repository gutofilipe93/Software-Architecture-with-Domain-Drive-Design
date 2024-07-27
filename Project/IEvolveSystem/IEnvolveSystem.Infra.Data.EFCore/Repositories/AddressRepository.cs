using IEnvolveSystem.Infra.Data.EFCore.Contexts;
using IEvolveSystem.Domain.Entities.ValueObject;
using IEvolveSystem.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnvolveSystem.Infra.Data.EFCore.Repositories
{
    public class AddressRepository : IAddressRepository
    {
        private readonly AppEFCoreDbContext _context;

        public AddressRepository(AppEFCoreDbContext context)
        {
            _context = context;
        }

        public Address Create(Address address)
        {
            _context.Addresses.Add(address);
            _context.SaveChanges();
            return address;
        }
    }
}
