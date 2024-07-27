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
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ICustomerService _customerService;

        public OrderService(IOrderRepository orderRepository, ICustomerService customerService)
        {
            _orderRepository = orderRepository;
            _customerService = customerService;
        }

        public Order Create(Order order)
        {
            order.Total = ApplyDiscountByNumberOrders(order.Total ?? 0);
            _customerService.ChangeCustomerType(order.CustomerId ?? 0);
            return _orderRepository.Create(order);
        }

        public void Delete(int id)
        {            
            _orderRepository.Delete(id);
        }

        public Order Update(Order order)
        {
            return _orderRepository.Update(order);
        }

        private decimal ApplyDiscountByNumberOrders(decimal total)
        {
            var count = _orderRepository.GetAll().Where(x => x.CustomerId == 1).Count();
            if (count >= 10)
                total = total - 200;

            if (total >= 1000)
                total = total - 100;

            return total;
        }
    }
}
