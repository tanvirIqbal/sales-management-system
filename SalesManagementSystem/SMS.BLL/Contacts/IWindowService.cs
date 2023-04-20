using SMS.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.BLL.Contacts
{
    public interface IWindowService
    {
        public Task<Window> Create(Window window);
        public void Delete(Window window);
        public void Update(Window window);
        public IEnumerable<Window> GetAll();
        public Window GetById(int Id);
    }
}
