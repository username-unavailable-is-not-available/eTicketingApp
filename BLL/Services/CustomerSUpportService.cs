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
    public class CustomarSupportService
    {
        public static List<CustomarSupportDTO> Get()
        {
            var data = DataAccess.CustomerSupportsData().Get();
            var mapper = MapperServices<CustomerSupport, CustomarSupportDTO>.GetMapper();
            return mapper.Map<List<CustomarSupportDTO>>(data);
        }
        public static bool Add(CustomarSupportDTO post)
        {

            var mapper = MapperServices<CustomarSupportDTO, CustomerSupport>.GetMapper();
            var mapped = mapper.Map<CustomerSupport>(post);
            return DataAccess.CustomerSupportsData().Add(mapped);
        }

        public static bool Update(CustomarSupportDTO post)
        {
            var mapper = MapperServices<CustomarSupportDTO, CustomerSupport>.GetMapper();
            var mapped = mapper.Map<CustomerSupport>(post);
            return DataAccess.CustomerSupportsData().Update(mapped);

        }

        public static bool Delete(int id)
        {

            return DataAccess.CustomerSupportsData().Delete(id);

        }
    }
}
