namespace BLL.DTOs
{
    public class BusDTO
    {
        public int Id { get; set; }
        public string BusName { get; set; }
        public string Route { get; set; }
        public decimal Price { get; set; }
        public int VehicleId { get; set; }
    }
}
