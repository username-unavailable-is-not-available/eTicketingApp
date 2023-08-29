using DAL.EF.Models;

namespace DAL.Interfaces
{
    public interface IAuth
    {
        User Authenticate(string uname, string pass);
    }
}
