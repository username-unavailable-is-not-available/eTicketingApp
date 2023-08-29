using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    internal class Context:DbContext
    {
        public DbSet<Ticket> tickets { get; set; }
        public DbSet<Bus> Buses { get; set; }
        public DbSet<Train> Trains  { get; set; }
        public DbSet<Airline> Airlines { get; set; }
        public DbSet<RouteAndSchedule> RouteAndSchedules { get; set; }
        public DbSet<TicketSales> TicketSales  { get; set; }
        public DbSet<CustomerSupport> customerSupports  { get; set; }
        
    }
}
