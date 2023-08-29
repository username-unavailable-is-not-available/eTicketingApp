namespace BLL.DTOs
{
    public class TrainDTO
    {
        public int Id { get; set; }
        public string TrainName { get; set; }
        public string Route { get; set; }
        public decimal TicketPrice { get; set; }
        public int VehicleId { get; set; }
    }
}
