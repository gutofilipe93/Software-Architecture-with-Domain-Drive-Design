using IEvolveSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEvolveSystem.Domain.Interfaces.Repositories
{
    public interface IOrderRepository
    {
        Order Create(Order order);
        Order Update(Order order);
        void Delete(int id);
        Order GetById(int id);
        IEnumerable<Order> GetAll();
    }
}
