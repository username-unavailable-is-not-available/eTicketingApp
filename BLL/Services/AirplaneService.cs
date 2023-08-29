using BLL.DTOs;
using DAL;
using DAL.EF.Models;
using System.Collections.Generic;

namespace BLL.Services
{
    public class AirplaneService
    {
        public static List<AirplaneDTO> Get()
        {
            var data = DataAccessFactory.AirplaneData().Get();
            var mapper = MapperService<Airplane, AirplaneDTO>.GetMapper();
            return mapper.Map<List<AirplaneDTO>>(data);
        }

        public static bool Create(AirplaneDTO Airplane)
        {
            var mapper = MapperService<AirplaneDTO, Airplane>.GetMapper();
            var mapped = mapper.Map<Airplane>(Airplane);
            return DataAccessFactory.AirplaneData().Create(mapped);
        }

        public static bool Update(AirplaneDTO Comment)
        {
            var mapper = MapperService<AirplaneDTO, Airplane>.GetMapper();
            var mapped = mapper.Map<Airplane>(Comment);
            return DataAccessFactory.AirplaneData().Update(mapped);

        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.AirplaneData().Delete(id);
        }
    }
}
