using BLL.DTOs;
using DAL;
using DAL.EF.Models;

namespace BLL.Services
{
    public class UserService
    {
        public static bool Create(UserDTO User)
        {
            var mapper = MapperService<UserDTO, User>.GetMapper();
            var mapped = mapper.Map<User>(User);
            return DataAccessFactory.UserData().Create(mapped);
        }
    }
}
