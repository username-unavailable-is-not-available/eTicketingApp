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
    }
}
