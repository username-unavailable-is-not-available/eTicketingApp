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
    public class TicketService
    {
        public static List<TicketDTO> Get()
        {
            var data = DataAccess.TicketData().Get();
            var mapper = MapperServices<Ticket, TicketDTO>.GetMapper();
            return mapper.Map<List<TicketDTO>>(data);
        }
        public static bool Add(TicketDTO post)
        {
            
            var mapper = MapperServices<TicketDTO, Ticket>.GetMapper();
            var mapped = mapper.Map<Ticket>(post);
            return DataAccess.TicketData().Add(mapped);
        }

        public static bool Update(TicketDTO post)
        {
            var mapper = MapperServices<TicketDTO, Ticket>.GetMapper();
            var mapped = mapper.Map<Ticket>(post);
            return DataAccess.TicketData().Update(mapped);

        }

        public static bool Delete(int id)
        {

            return DataAccess.TicketData().Delete(id);

        }
    }
}
