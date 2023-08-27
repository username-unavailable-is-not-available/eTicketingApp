using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Models;
using System.Collections.Generic;

namespace BLL.Services
{
    public class TicketManageService
    {
        public static List<TicketManageDTO> Get()
        {
            var data = DataAccessFactory.TicketManagement().Get();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TicketManage, TicketManageDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<List<TicketManageDTO>>(data);
            return converted;
        }

        public static bool Add(TicketManageDTO Tickets)
        {
            var mapper = MapperService<TicketManageDTO, TicketManage>.GetMapper();
            var mapped = mapper.Map<TicketManage>(Tickets);
            return DataAccessFactory.TicketManagement().Create(mapped);
        }

        public static bool Update(TicketManageDTO Tickets)
        {
            var mapper = MapperService<TicketManageDTO, TicketManage>.GetMapper();
            var mapped = mapper.Map<TicketManage>(Tickets);
            return DataAccessFactory.TicketManagement().Update(mapped);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.TicketManagement().Delete(id);
        }
    }
}