using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class RouteAndSchedule
    {
        public int Id { get; set; }
        [Required]
        public int RouteID { get; set; }
        public string RouteName { get; set; }
        public string VehicleType { get; set; }
        public string VehicleName { get; set; }
        public string StartPoint { get; set; }
        public string EndPoint { get; set; }
        public string DepartedTime { get; set; }
        public string ArrivalTime { get; set; }
    }
}
