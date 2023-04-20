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
    public class SubElementRepository : ISubElementRepository
    {
        private readonly DatabaseContext _databaseContext;

        public SubElementRepository(DatabaseContext databaseContext)
        {
            this._databaseContext = databaseContext;
        }

        public async Task<SubElement> Create(SubElement subElement)
        {
            _databaseContext.SubElements.Add(subElement);
            await _databaseContext.SaveChangesAsync();
            return subElement;
        }

        public void Delete(SubElement subElement)
        {
            _databaseContext.SubElements.Remove(subElement);
            _databaseContext.SaveChanges();
        }

        public IEnumerable<SubElement> GetAll()
        {
            return _databaseContext.SubElements
            .ToList();
        }

        public SubElement GetById(int Id)
        {
            return _databaseContext.SubElements
            .FirstOrDefault(se => se.Id == Id);
        }

        public void Update(SubElement subElement)
        {
            _databaseContext.Entry(subElement).State = EntityState.Modified;
            _databaseContext.SaveChanges();
        }
    }
}
