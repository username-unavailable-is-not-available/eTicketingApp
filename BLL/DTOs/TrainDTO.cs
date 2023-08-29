using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class TrainDTO
    {
        public int Id { get; set; }
        
        public string TrainName { get; set; }
       
        public string TrainNo { get; set; }

        public string TrainRoute { get; set; }
    }
}
