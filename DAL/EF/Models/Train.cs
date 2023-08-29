using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.EF.Models
{
    public class Train
    {
        public int Id { get; set; }
        public string TrainName { get; set; }
        public string Route { get; set; }
        public decimal TicketPrice { get; set; }

        [ForeignKey("Vehicle")]
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}
