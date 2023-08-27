using DAL.EF.Models;
using DAL.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repos
{
    public class UserManageRepo : Repo, IRepo<UserManage, int, bool>
    {
        public bool Create(UserManage obj)
        {
            db.Users.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var ex = Get(id);
            db.Users.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<UserManage> Get()
        {
            return db.Users.ToList();
        }

        public UserManage Get(int id)
        {
            return db.Users.Find(id);
        }

        public bool Update(UserManage obj)
        {
            var ex = Get(obj.Id);
            db.Entry(ex).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}