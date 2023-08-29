using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Models;
using System.Collections.Generic;

namespace BLL.Services
{
    public class EmployeeManageService
    {
        public static List<EmployeeManageDTO> Get()
        {
            var data = DataAccessFactory.EmployeeManagement().Get();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<EmployeeManage, EmployeeManageDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<List<EmployeeManageDTO>>(data);
            return converted;
        }

        public static bool Add(EmployeeManageDTO Employees)
        {
            var mapper = MapperService<EmployeeManageDTO, EmployeeManage>.GetMapper();
            var mapped = mapper.Map<EmployeeManage>(Employees);
            return DataAccessFactory.EmployeeManagement().Create(mapped);
        }

        public static bool Update(EmployeeManageDTO Employees)
        {
            var mapper = MapperService<EmployeeManageDTO, EmployeeManage>.GetMapper();
            var mapped = mapper.Map<EmployeeManage>(Employees);
            return DataAccessFactory.EmployeeManagement().Update(mapped);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.EmployeeManagement().Delete(id);
        }
    }
}