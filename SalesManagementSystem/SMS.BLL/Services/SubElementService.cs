using SMS.BLL.Contacts;
using SMS.DAL.Contacts;
using SMS.DAL.Repositories;
using SMS.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.BLL.Services
{
    public class SubElementService : ISubElementService
    {
        private readonly ISubElementService _subElementRepository;

        public SubElementService(ISubElementService subElementRepository)
        {
            this._subElementRepository = subElementRepository;
        }
        public Task<SubElement> Create(SubElement subElement)
        {
            return _subElementRepository.Create(subElement);
        }

        public void Delete(SubElement subElement)
        {
            _subElementRepository.Delete(subElement);
        }

        public IEnumerable<SubElement> GetAll()
        {
            var subElements = _subElementRepository.GetAll();
            return subElements;
        }

        public SubElement GetById(int Id)
        {
            return _subElementRepository.GetById(Id);
        }

        public void Update(SubElement subElement)
        {
            _subElementRepository.Update(subElement);
        }
    }
}
