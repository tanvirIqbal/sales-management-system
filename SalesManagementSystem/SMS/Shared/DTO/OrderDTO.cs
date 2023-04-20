using SMS.Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SMS.Shared.Enums;

namespace SMS.Shared.DTO
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public StateCode State { get; set; }
        public List<WindowDTO> Windows { get; set; }
    }
}
