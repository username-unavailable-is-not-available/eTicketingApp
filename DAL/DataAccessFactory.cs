using DAL.EF.Models;
using DAL.Interfaces;
using DAL.Repos;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<TicketManage, int, bool> TicketManagement()
        {
            return new TicketManageRepo();
        }
        public static IRepo<UserManage, int, bool> UserManagement()
        {
            return new UserManageRepo();
        }
        public static IRepo<EmployeeManage, int, bool> EmployeeManagement()
        {
            return new EmployeeManageRepo();
        }
        public static IRepo<FinanceManage, int, bool> FinanceManagement()
        {
            return new FinanceManageRepo();
        }
        public static IRepo<RouteManage, int, bool> RouteManagement()
        {
            return new RouteManageRepo();
        }
    }
}
