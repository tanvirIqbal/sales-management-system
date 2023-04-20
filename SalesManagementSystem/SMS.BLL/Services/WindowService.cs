using SMS.BLL.Contacts;
using SMS.DAL.Contacts;
using SMS.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.BLL.Services
{
    public class WindowService : IWindowService
    {
        private readonly IWindowService _windowRepository;

        public WindowService(IWindowService windowRepository)
        {
            this._windowRepository = windowRepository;
        }
        public Task<Window> Create(Window window)
        {
            return _windowRepository.Create(window);
        }

        public void Delete(Window window)
        {
            _windowRepository.Delete(window);
        }

        public IEnumerable<Window> GetAll()
        {
            var windows = _windowRepository.GetAll();
            return windows;
        }

        public Window GetById(int Id)
        {
            return _windowRepository.GetById(Id);
        }

        public void Update(Window window)
        {
            _windowRepository.Update(window);
        }
    }
}
