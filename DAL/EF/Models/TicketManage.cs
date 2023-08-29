using System.Collections.Generic;

namespace DAL.EF.Models
{
    public class TicketManage
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public string Vehicle { get; set; }
        public string Class { get; set; }
        public virtual ICollection<RouteManage> Routes { get; set; }
        public TicketManage()
        {
            Routes = new List<RouteManage>();
        }
    }
}