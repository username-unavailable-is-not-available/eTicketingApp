using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.EF.Models
{
    public class Airplane
    {
        public int Id { get; set; }
        public string AirplaneName { get; set; }
        public string FlightRoute { get; set; }
        public decimal TicketPrice { get; set; }

        [ForeignKey("Vehicle")]
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}
