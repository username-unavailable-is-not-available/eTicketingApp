using BLL.DTOs;
using DAL;
using DAL.EF.Models;
using System.Collections.Generic;

namespace BLL.Services
{
    public class BusService
    {
        public static List<BusDTO> Get()
        {
            var data = DataAccessFactory.BusData().Get();
            var mapper = MapperService<Bus, BusDTO>.GetMapper();
            return mapper.Map<List<BusDTO>>(data);
        }

        public static bool Create(BusDTO Bus)
        {
            var mapper = MapperService<BusDTO, Bus>.GetMapper();
            var mapped = mapper.Map<Bus>(Bus);
            return DataAccessFactory.BusData().Create(mapped);
        }

        public static bool Update(BusDTO Comment)
        {
            var mapper = MapperService<BusDTO, Bus>.GetMapper();
            var mapped = mapper.Map<Bus>(Comment);
            return DataAccessFactory.BusData().Update(mapped);

        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.BusData().Delete(id);
        }
    }
}
