﻿using SMS.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.DAL.Contacts
{
    public interface ISubElementRepository
    {
        public Task<SubElement> Create(SubElement subElement);
        public void Delete(SubElement subElement);
        public void Update(SubElement subElement);
        public IEnumerable<SubElement> GetAll();
        public SubElement GetById(int Id);
    }
}
