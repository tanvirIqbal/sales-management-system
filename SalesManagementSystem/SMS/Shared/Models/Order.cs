using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SMS.Shared.Enums;

namespace SMS.Shared.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public StateCode State { get; set; }
        public List<Window> Windows { get; set; }
    }
}
