using DAL.EF.Models;
using System.Data.Entity;

namespace DAL.EF
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Bus> Buses { get; set; }
    }
}
