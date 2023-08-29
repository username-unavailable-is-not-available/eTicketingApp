using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Airline
    {
        public int Id { get; set; }
        [Required]
        public string AirlineName { get; set; }
        [Required]
        public int AirlineNo { get; set; }
        public string detailes { get; set; }

    }
}
