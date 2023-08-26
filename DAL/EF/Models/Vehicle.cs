using System.Collections.Generic;

namespace DAL.EF.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Bus> Buses { get; set; }
        //public virtual ICollection<Train> Trains { get; set; }
        public Vehicle()
        {
            Buses = new List<Bus>();
            //Trains = new List<Train>();
        }
    }
}
