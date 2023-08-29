using BLL.DTOs;
using AutoMapper;
using DAL.EF.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class RouteAndScheduleService
    {
        public static List<RouteAndScheduleDTO> Get()
        {
            var data = DataAccess.RouteAndScheduleData().Get();
            var mapper = MapperServices<RouteAndSchedule, RouteAndScheduleDTO>.GetMapper();
            return mapper.Map<List<RouteAndScheduleDTO>>(data);
        }
        public static bool Add(RouteAndScheduleDTO post)
        {

            var mapper = MapperServices<RouteAndScheduleDTO, RouteAndSchedule>.GetMapper();
            var mapped = mapper.Map<RouteAndSchedule>(post);
            return DataAccess.RouteAndScheduleData().Add(mapped);
        }

        public static bool Update(RouteAndScheduleDTO post)
        {
            var mapper = MapperServices<RouteAndScheduleDTO, RouteAndSchedule>.GetMapper();
            var mapped = mapper.Map<RouteAndSchedule>(post);
            return DataAccess.RouteAndScheduleData().Update(mapped);

        }

        public static bool Delete(int id)
        {

            return DataAccess.RouteAndScheduleData().Delete(id);

        }
    }
}
