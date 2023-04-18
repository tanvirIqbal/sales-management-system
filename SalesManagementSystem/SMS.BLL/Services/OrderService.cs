using SMS.BLL.Contacts;
using SMS.DAL.Contacts;
using SMS.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.BLL.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            this._orderRepository = orderRepository;
        }
        public Task<Order> Create(Order order)
        {
            return _orderRepository.Create(order);
        }

        public void Delete(Order order)
        {
            _orderRepository.Delete(order);
        }

        public IEnumerable<Order> GetAll()
        {
            var orders = _orderRepository.GetAll();
            return orders;
        }

        public Order GetById(int Id)
        {
            return _orderRepository.GetById(Id);
        }

        public void Update(Order order)
        {
            _orderRepository.Update(order);
        }
    }
}
