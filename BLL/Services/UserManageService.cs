using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Models;
using System.Collections.Generic;

namespace BLL.Services
{
    public class UserManageService
    {
        public static List<UserManageDTO> Get()
        {
            var data = DataAccessFactory.UserManagement().Get();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<UserManage, UserManageDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<List<UserManageDTO>>(data);
            return converted;
        }

        public static bool Add(UserManageDTO Users)
        {
            var mapper = MapperService<UserManageDTO, UserManage>.GetMapper();
            var mapped = mapper.Map<UserManage>(Users);
            return DataAccessFactory.UserManagement().Create(mapped);
        }

        public static bool Update(UserManageDTO Users)
        {
            var mapper = MapperService<UserManageDTO, UserManage>.GetMapper();
            var mapped = mapper.Map<UserManage>(Users);
            return DataAccessFactory.UserManagement().Update(mapped);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.UserManagement().Delete(id);
        }
    }
}