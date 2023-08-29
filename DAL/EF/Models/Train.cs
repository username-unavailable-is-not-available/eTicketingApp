using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Train
    {
        public int Id { get; set; }
        [Required]
        public string TrainName { get; set; }
        [Required]
        public string TrainNo { get; set; }
        public string TrainRoute { get; set; }
       
    }
}
