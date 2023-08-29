using DAL.EF.Models;
using DAL.Interfaces;
using DAL.Repos;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Vehicle, int, bool> VehicleData()
        {
            return new VehicleRepo();
        }
        public static IRepo<Bus, int, bool> BusData()
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
        }
        public static IRepo<Token, int, Token> TokensData()
        {
            return new TokenRepo();
        }
        public static IRepo<Train, int, bool> TrainData()
        {
            return new TrainRepo();
        }
    }
}
