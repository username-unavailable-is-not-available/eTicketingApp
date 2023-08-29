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
    public class BusService
    {
        public static List<BusDTO> Get()
        {
            var data = DataAccess.BusData().Get();
            var mapper = MapperServices<Bus, BusDTO >.GetMapper();
            return mapper.Map<List<BusDTO>>(data);
        }
        public static bool Add(BusDTO post)
        {

            var mapper = MapperServices<BusDTO, Bus>.GetMapper();
            var mapped = mapper.Map<Bus>(post);
            return DataAccess.BusData().Add(mapped);
        }

        public static bool Update(BusDTO post)
        {
            var mapper = MapperServices<BusDTO, Bus>.GetMapper();
            var mapped = mapper.Map<Bus>(post);
            return DataAccess.BusData().Update(mapped);

        }

        public static bool Delete(int id)
        {

            return DataAccess.BusData().Delete(id);

        }
    }
}
