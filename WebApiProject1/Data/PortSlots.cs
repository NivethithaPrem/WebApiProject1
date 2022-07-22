using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiProject1.Data
{
    public class PortSlots
    {
        [Key]
        
        public int Slotid { get; set; }
        public int? Ruid { get; set; }
        public int? Sluid { get; set; }
        public string Status { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public long? Cost { get; set; }
    }
}
