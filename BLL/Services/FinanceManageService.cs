using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Models;
using System.Collections.Generic;

namespace BLL.Services
{
    public class FinanceManageService
    {
        public static List<FinanceManageDTO> Get()
        {
            var data = DataAccessFactory.FinanceManagement().Get();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<FinanceManage, FinanceManageDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<List<FinanceManageDTO>>(data);
            return converted;
        }

        public static bool Add(FinanceManageDTO Finances)
        {
            var mapper = MapperService<FinanceManageDTO, FinanceManage>.GetMapper();
            var mapped = mapper.Map<FinanceManage>(Finances);
            return DataAccessFactory.FinanceManagement().Create(mapped);
        }

        public static bool Update(FinanceManageDTO Finances)
        {
            var mapper = MapperService<FinanceManageDTO, FinanceManage>.GetMapper();
            var mapped = mapper.Map<FinanceManage>(Finances);
            return DataAccessFactory.FinanceManagement().Update(mapped);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.FinanceManagement().Delete(id);
        }
    }
}