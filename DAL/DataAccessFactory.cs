using DAL.EF.Models;
using DAL.Interfaces;
using DAL.Repos;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Vehicle, int, bool> VehicleData()
        public static IRepo<TicketManage, int, bool> TicketManagement()
        {
            return new VehicleRepo();
            return new TicketManageRepo();
        }
        public static IRepo<Bus, int, bool> BusData()
        public static IRepo<UserManage, int, bool> UserManagement()
        {
            return new BusRepo();
        }
        public static IRepo<User, string, bool> UserData()
        {
            return new UserRepo();
        }
        public static IAuth AuthData()
        {
            return new UserRepo();
            return new UserManageRepo();
        }
        public static IRepo<Token, int, Token> TokensData()
        public static IRepo<EmployeeManage, int, bool> EmployeeManagement()
        {
            return new TokenRepo();
            return new EmployeeManageRepo();
        }
        public static IRepo<Train, int, bool> TrainData()
        public static IRepo<FinanceManage, int, bool> FinanceManagement()
        {
            return new TrainRepo();
            return new FinanceManageRepo();
        }
        public static IRepo<Airplane, int, bool> AirplaneData()
        public static IRepo<RouteManage, int, bool> RouteManagement()
        {
            return new AirplaneRepo();
            return new RouteManageRepo();
        }
    }
}
