using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiProject1.Models
{
    public class PortSlot
    {
        public int Id { get; set; }
        public int Slotid { get; set; }
        public int? Ruid { get; set; }
        public int? Sluid { get; set; }
        public string Status { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public long? Cost { get; set; }
    }
}
