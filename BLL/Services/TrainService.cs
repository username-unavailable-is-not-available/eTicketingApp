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
    public class TrainService
    {
        public static List<TrainDTO> Get()
        {
            var data = DataAccess.TrainData().Get();
            var mapper = MapperServices<Train, TrainDTO>.GetMapper();
            return mapper.Map<List<TrainDTO>>(data);
        }
        public static bool Add(TrainDTO post)
        {

            var mapper = MapperServices<TrainDTO, Train>.GetMapper();
            var mapped = mapper.Map<Train>(post);
            return DataAccess.TrainData().Add(mapped);
        }

        public static bool Update(TrainDTO post)
        {
            var mapper = MapperServices<TrainDTO, Train>.GetMapper();
            var mapped = mapper.Map<Train>(post);
            return DataAccess.TrainData().Update(mapped);

        }

        public static bool Delete(int id)
        {

            return DataAccess.TrainData().Delete(id);

        }
    }
}
