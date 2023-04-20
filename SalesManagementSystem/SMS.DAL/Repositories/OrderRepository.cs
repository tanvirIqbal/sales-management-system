using Microsoft.EntityFrameworkCore;
using SMS.DAL.Contacts;
using SMS.DAL.Data;
using SMS.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.DAL.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DatabaseContext _databaseContext;

        public OrderRepository(DatabaseContext databaseContext)
        {
            this._databaseContext = databaseContext;
        }
        public async Task<Order> Create(Order order)
        {
            _databaseContext.Orders.Add(order);
            await _databaseContext.SaveChangesAsync();
            return order;
        }

        public void Delete(Order order)
        {
            _databaseContext.Orders.Remove(order);
            _databaseContext.SaveChanges();
        }

        public IEnumerable<Order> GetAll()
        {
            return _databaseContext.Orders
            .Include(o => o.Windows)
            .ThenInclude(w => w.SubElements)
            .ToList();
        }

        public Order GetById(int Id)
        {
            return _databaseContext.Orders
            .Include(o => o.Windows)
            .ThenInclude(w => w.SubElements)
            .FirstOrDefault(o => o.Id == Id);
        }

        public void Update(Order order)
        {
            _databaseContext.Entry(order).State = EntityState.Modified;
            _databaseContext.SaveChanges();
        }
    }
}
