using IEvolveSystem.Domain.Entities.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEvolveSystem.Domain.Interfaces.Repositories
{
    public interface IAddressRepository
    {
        Address Create(Address address);
    }
}
