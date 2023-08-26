using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Models;
using System.Collections.Generic;
using System.Linq;

namespace BLL.Services
{
    public class BusService
    {
        public static List<BusDTO> Get()
        {
            var data = DataAccessFactory.BusData().Get();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Bus, BusDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<List<BusDTO>>(data);
            return converted;
        }

        public static List<BusDTO> Get(string route)
        {
            var data = (from b in DataAccessFactory.BusData().Get()
                        where b.Route.ToLower().Contains(route.ToLower())
                        select b).ToList();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Bus, BusDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<List<BusDTO>>(data);
            return converted;
        }

        public static List<BusDTO> Get(decimal price)
        {
            var data = (from b in DataAccessFactory.BusData().Get()
                        where b.Price == price
                        select b).ToList();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Bus, BusDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<List<BusDTO>>(data);
            return converted;
        }

        public static List<BusDTO> Get(string route, decimal price)
        {
            var data = (from b in DataAccessFactory.BusData().Get()
                        where b.Route.ToLower().Contains(route.ToLower())
                            && b.Price == price
                        select b).ToList();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Bus, BusDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<List<BusDTO>>(data);
            return converted;
        }
    }
}
