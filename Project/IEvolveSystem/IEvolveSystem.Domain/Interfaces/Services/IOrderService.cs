using IEvolveSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEvolveSystem.Domain.Interfaces.Services
{
    public interface IOrderService
    {
        Order Create(Order order);
        Order Update(Order order);
        void Delete(int id);
    }
}
