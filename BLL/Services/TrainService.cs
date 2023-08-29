using BLL.DTOs;
using DAL;
using DAL.EF.Models;
using System.Collections.Generic;

namespace BLL.Services
{
    public class TrainService
    {
        public static List<TrainDTO> Get()
        {
            var data = DataAccessFactory.TrainData().Get();
            var mapper = MapperService<Train, TrainDTO>.GetMapper();
            return mapper.Map<List<TrainDTO>>(data);
        }

        public static bool Create(TrainDTO Train)
        {
            var mapper = MapperService<TrainDTO, Train>.GetMapper();
            var mapped = mapper.Map<Train>(Train);
            return DataAccessFactory.TrainData().Create(mapped);
        }

        public static bool Update(TrainDTO Comment)
        {
            var mapper = MapperService<TrainDTO, Train>.GetMapper();
            var mapped = mapper.Map<Train>(Comment);
            return DataAccessFactory.TrainData().Update(mapped);

        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.TrainData().Delete(id);
        }
    }
}
