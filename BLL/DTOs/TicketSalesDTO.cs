using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class TicketSalesDTO
    {
        public int Id { get; set; }
        
        public int PassengerId { get; set; }
        public string PassengerName { get; set; }
        public string VehicleType { get; set; }
       
        public int VechileNo { get; set; }
        public string VehicleName { get; set; }
       
        public int PaymentId { get; set; }
        public string PaymentAmount { get; set; }
        public string TicketStatus { get; set; }
    }
}
