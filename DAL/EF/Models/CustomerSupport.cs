using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class CustomerSupport
    {
        public int id { get; set; }
        public int Id { get; internal set; }
        [Required]
        public int RequestId { get; set; }
        public string RequestType { get; set; }
        [Required]
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string ContactDetails { get; set; }
        public string SupportDetails { get; set; }
        public string Status { get; set; }
    }
}
