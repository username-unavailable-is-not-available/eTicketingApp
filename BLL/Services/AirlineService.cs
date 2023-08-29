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
    public class AirlineService
    {
        public static List<AirlineDTO> Get()
        {
            var data = DataAccess.AirlineData().Get();
            var mapper = MapperServices<Airline, AirlineDTO>.GetMapper();
            return mapper.Map<List<AirlineDTO>>(data);
        }
        public static bool Add(AirlineDTO post)
        {

            var mapper = MapperServices<AirlineDTO, Airline>.GetMapper();
            var mapped = mapper.Map<Airline>(post);
            return DataAccess.AirlineData().Add(mapped);
        }

        public static bool Update(AirlineDTO post)
        {
            var mapper = MapperServices<AirlineDTO, Airline>.GetMapper();
            var mapped = mapper.Map<Airline>(post);
            return DataAccess.AirlineData().Update(mapped);

        }

        public static bool Delete(int id)
        {

            return DataAccess.AirlineData().Delete(id);

        }
    }
}
