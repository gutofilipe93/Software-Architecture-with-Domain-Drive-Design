using IEvolveSystem.Domain.Entities.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEvolveSystem.Domain.Interfaces.Services
{
    public interface IAddressService
    {
        Address Create(Address address);
    }
}
