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
    public class OrderRepository : IOrderRepository
    {
        private readonly AppEFCoreDbContext _context;

        public OrderRepository(AppEFCoreDbContext context)
        {
            _context = context;
        }

        public Order Create(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
            return order;
        }

        public void Delete(int id)
        {
            var order = _context.Orders.Find(id);
            _context.Remove(order ?? new Order());
            _context.SaveChanges();
        }

        public IEnumerable<Order> GetAll()
        {
            return _context.Orders.ToList();
        }

        public Order GetById(int id)
        {
            var order = _context.Orders.Find(id);
            return order ?? new Order();
        }

        public Order Update(Order order)
        {
            _context.Orders.Update(order);
            _context.SaveChanges();
            return order;
        }
    }
}
