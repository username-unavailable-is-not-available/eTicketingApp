using DAL.EF.Models;
using System.Data.Entity;

namespace DAL.EF
{
    public class AdminContext : DbContext
    {
        public DbSet<TicketManage> Tickets { get; set; }
        public DbSet<UserManage> Users { get; set; }
        public DbSet<EmployeeManage> Employees { get; set; }
        public DbSet<FinanceManage> Finances { get; set; }
        public DbSet<RouteManage> Routes { get; set; }
    }
}