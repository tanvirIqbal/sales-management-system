using SMS.Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Shared.DTO
{
    public class WindowDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int QuantityOfWindows { get; set; }
        public int TotalSubElements { get; set; }
        public bool IsDeleted { get; set; }
        public List<SubElementDTO> SubElements { get; set; } = new List<SubElementDTO>();
    }
}
