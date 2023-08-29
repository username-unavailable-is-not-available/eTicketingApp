using DAL.EF.Models;
using System.Data.Entity;

namespace DAL.EF
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Token> Tokens { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Bus> Buses { get; set; }
        public DbSet<Train> Trains { get; set; }
        public DbSet<Airplane> Airplanes { get; set; }
    }
}
