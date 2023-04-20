using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Shared.Models
{
    public class Window
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int QuantityOfWindows { get; set; }

        public int TotalSubElements { get; set; }

        public List<SubElement> SubElements { get; set; }
        public bool IsDeleted { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
