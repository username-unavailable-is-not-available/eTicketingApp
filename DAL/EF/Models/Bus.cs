using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.EF.Models
{
    public class Bus
    {
        public int Id { get; set; }
        public string BusName { get; set; }
        public string Route { get; set; }
        public decimal Price { get; set; }

        [ForeignKey("Vehicle")]
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}
