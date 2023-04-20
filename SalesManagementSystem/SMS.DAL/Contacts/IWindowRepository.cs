using SMS.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.DAL.Contacts
{
    public interface IWindowRepository
    {
        public Task<Window> Create(Window window);
        public void Delete(Window window);
        public void Update(Window window);
        public IEnumerable<Window> GetAll();
        public Window GetById(int Id);
    }
}
