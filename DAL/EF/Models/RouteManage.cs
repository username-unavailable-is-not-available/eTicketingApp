using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.EF.Models
{
    public class RouteManage
    {
        public int Id { get; set; }
        public string Route { get; set; }

        [ForeignKey("Ticket")]
        public int TicketId { get; set; }
        public TicketManage Ticket { get; set; }
    }
}