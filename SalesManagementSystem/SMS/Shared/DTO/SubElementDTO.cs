using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SMS.Shared.Enums;

namespace SMS.Shared.DTO
{
    public class SubElementDTO
    {
        public int Id { get; set; }
        public int Element { get; set; }
        public ElementType Type { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
