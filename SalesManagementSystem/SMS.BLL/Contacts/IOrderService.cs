using SMS.Shared.DTO;
using SMS.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.BLL.Contacts
{
    public interface IOrderService
    {
        public Task<Order> Create(OrderDTO order);
        public void Delete(OrderDTO order);
        public void Update(OrderDTO order);
        public IEnumerable<OrderDTO> GetAll();
        public OrderDTO GetById(int Id);
    }
}
