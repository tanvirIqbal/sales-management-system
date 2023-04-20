using AutoMapper;
using SMS.BLL.Contacts;
using SMS.DAL.Contacts;
using SMS.Shared.DTO;
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
        private readonly IMapper _mapper;

        public OrderService(IOrderRepository orderRepository, IMapper mapper)
        {
            this._orderRepository = orderRepository;
            this._mapper = mapper;
        }
        public Task<Order> Create(OrderDTO orderDto)
        {
            var order = _mapper.Map<Order>(orderDto);
            return _orderRepository.Create(order);
        }

        public void Delete(int id)
        {
            var order = _orderRepository.GetById(id);
            _orderRepository.Delete(order);
        }

        public IEnumerable<OrderDTO> GetAll()
        {
            var orders = _orderRepository.GetAll();
            return _mapper.Map<List<OrderDTO>>(orders);
        }

        public OrderDTO GetById(int Id)
        {
            var order = _orderRepository.GetById(Id);
            return _mapper.Map<OrderDTO>(order);
        }

        public void Update(OrderDTO orderDto)
        {
            var order = _mapper.Map<Order>(orderDto);
            _orderRepository.Update(order);
        }
    }
}
