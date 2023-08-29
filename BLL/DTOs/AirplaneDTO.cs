namespace BLL.DTOs
{
    public class AirplaneDTO
    {
        public int Id { get; set; }
        public string AirplaneName { get; set; }
        public string FlightRoute { get; set; }
        public decimal TicketPrice { get; set; }
        public int VehicleId { get; set; }
    }
}
