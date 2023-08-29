using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string VehicleType { get; set; }
        public string StartPlace { get; set; }
        public string EndPlace { get; set; }
        public DateTime date { get; set; }
    }
}
