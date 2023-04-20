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
    public class WindowRepository : IWindowRepository
    {
        private readonly DatabaseContext _databaseContext;

        public WindowRepository(DatabaseContext databaseContext)
        {
            this._databaseContext = databaseContext;
        }

        public async Task<Window> Create(Window window)
        {
            _databaseContext.Windows.Add(window);
            await _databaseContext.SaveChangesAsync();
            return window;
        }

        public void Delete(Window window)
        {
            _databaseContext.Windows.Remove(window);
            _databaseContext.SaveChanges();
        }

        public IEnumerable<Window> GetAll()
        {
            return _databaseContext.Windows
            .Include(w => w.SubElements)
            .ToList();
        }

        public Window GetById(int Id)
        {
            return _databaseContext.Windows
            .Include(w => w.SubElements)
            .FirstOrDefault(w => w.Id == Id);
        }

        public void Update(Window window)
        {
            _databaseContext.Entry(window).State = EntityState.Modified;
            _databaseContext.SaveChanges();
        }
    }
}
