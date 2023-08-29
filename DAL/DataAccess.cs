using DAL.EF.Models;
using DAL.Interfaces;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccess
    {
        public static IRepo<Ticket, int, bool> TicketData()
        {
            return new TicketRepos();
        }

        public static IRepo<Bus, int, bool> BusData()
        {
            return new BusRepos();
        }
        
        public static IRepo<Train, int, bool> TrainData()
        {
            return new TrainRepos();
        }
        
        public static IRepo<Airline, int, bool> AirlineData()
        {
            return new AirlineRepos();
        }
        public static IRepo<RouteAndSchedule, int, bool> RouteAndScheduleData()
        {
            return new RouteAndScheduleRepos();
        }
        
        public static IRepo<TicketSales, int, bool> TicketSalesData()
        {
            return new TicketSalesRepos();
        }
        public static IRepo<CustomerSupport, int, bool> CustomerSupportsData()
        {
            return new CustomerSupportRepos();
        }
    }
}
