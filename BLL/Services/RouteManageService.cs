using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Models;
using System.Collections.Generic;

namespace BLL.Services
{
    public class RouteManageService
    {
        public static List<RouteManageDTO> Get()
        {
            var data = DataAccessFactory.RouteManagement().Get();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<RouteManage, RouteManageDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<List<RouteManageDTO>>(data);
            return converted;
        }

        public static bool Add(RouteManageDTO Routes)
        {
            var mapper = MapperService<RouteManageDTO, RouteManage>.GetMapper();
            var mapped = mapper.Map<RouteManage>(Routes);
            return DataAccessFactory.RouteManagement().Create(mapped);
        }

        public static bool Update(RouteManageDTO Routes)
        {
            var mapper = MapperService<RouteManageDTO, RouteManage>.GetMapper();
            var mapped = mapper.Map<RouteManage>(Routes);
            return DataAccessFactory.RouteManagement().Update(mapped);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.RouteManagement().Delete(id);
        }
    }
}