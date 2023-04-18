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
        public Task<Order> Create(Order order);
        public void Delete(Order order);
        public void Update(Order order);
        public IEnumerable<Order> GetAll();
        public Order GetById(int Id);
    }
}
