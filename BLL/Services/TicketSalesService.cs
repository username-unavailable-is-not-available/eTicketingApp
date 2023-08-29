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
    public class TicketSalesService
    {
        public static List<TicketSalesDTO> Get()
        {
            var data = DataAccess.TicketSalesData().Get();
            var mapper = MapperServices<TicketSales, TicketSalesDTO>.GetMapper();
            return mapper.Map<List<TicketSalesDTO>>(data);
        }
        public static bool Add(TicketSalesDTO post)
        {

            var mapper = MapperServices<TicketSalesDTO, TicketSales>.GetMapper();
            var mapped = mapper.Map<TicketSales>(post);
            return DataAccess.TicketSalesData().Add(mapped);
        }

        public static bool Update(TicketSalesDTO post)
        {
            var mapper = MapperServices<TicketSalesDTO, TicketSales>.GetMapper();
            var mapped = mapper.Map<TicketSales>(post);
            return DataAccess.TicketSalesData().Update(mapped);

        }

        public static bool Delete(int id)
        {

            return DataAccess.TicketSalesData().Delete(id);

        }
    }
}
