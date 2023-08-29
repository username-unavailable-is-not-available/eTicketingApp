using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class TicketSales
    {
        public int Id { get; set; }
        [Required]
        public int PassengerId { get; set; }
        public string PassengerName { get; set; }
        public string VehicleType { get; set; }
        [Required]
        public int VechileNo { get; set; }
        public string VehicleName { get; set; }
        [Required]
        public int PaymentId { get; set; }
        public string PaymentAmount { get; set; }
        public string TicketStatus { get; set; }
    }
}
