using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class BusDTO
    {
        public int Id { get; set; }    
        public string BusName { get; set; }       
        public string BusNo { get; set; }
        public string BusRoute { get; set; }
        public string BusType { get; set; }
        public string TotalSeat { get; set; }
        public string TicketPrice { get; set; }
    }
}
