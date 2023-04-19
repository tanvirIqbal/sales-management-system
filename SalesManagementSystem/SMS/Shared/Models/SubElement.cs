using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SMS.Shared.Enums;

namespace SMS.Shared.Models
{
    public class SubElement
    {
        public int Id { get; set; }

        [Required]
        public int Element { get; set; }

        [Required]
        public ElementType Type { get; set; }

        [Required]
        public int Width { get; set; }

        [Required]
        public int Height { get; set; }

        public int WindowId { get; set; }
        public Window Window { get; set; }
    }
}
