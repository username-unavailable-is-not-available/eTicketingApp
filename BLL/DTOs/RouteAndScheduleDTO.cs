using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class RouteAndScheduleDTO
    {
        public int Id { get; set; }
        
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
