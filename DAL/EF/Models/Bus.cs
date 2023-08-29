using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Bus
    {
        public int Id { get; set; }
        [Required]
        public string BusName { get; set; }
        [Required]
        public string BusNo { get; set; }

        public string BusRoute { get; set; }
        public string BusType { get; set; }
        public string TotalSeat { get; set; }
        public string TicketPrice { get; set; }
    }
}
