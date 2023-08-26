using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Models;
using System.Collections.Generic;

namespace BLL.Services
{
    public class VehicleService
    {
        public static List<VehicleDTO> Get()
        {
            var data = DataAccessFactory.VehicleData().Get();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Vehicle, VehicleDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<List<VehicleDTO>>(data);
            return converted;
        }

        public static VehicleDTO Get(int id)
        {
            var data = DataAccessFactory.VehicleData().Get(id);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Vehicle, VehicleDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<VehicleDTO>(data);
            return converted;
        }
    }
}
