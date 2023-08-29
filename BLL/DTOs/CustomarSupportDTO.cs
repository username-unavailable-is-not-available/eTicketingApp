using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class CustomarSupportDTO
    {
        public int id { get; set; }
        
        public int RequestId { get; set; }
        public string RequestType { get; set; }
        
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string ContactDetails { get; set; }
        public string SupportDetails { get; set; }
        public string Status { get; set; }
    }
}
