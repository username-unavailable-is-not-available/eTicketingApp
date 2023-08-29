using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repos
{
    public class UserRepo : Repo, IRepo<User, string, bool>, IAuth
    {
        public bool Create(User obj)
        {
            db.Users.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<User> Get()
        {
            throw new NotImplementedException();
        }

        public User Get(string id)
        {
            throw new NotImplementedException();
        }

        public bool Update(User obj)
        {
            throw new NotImplementedException();
        }

        public User Authenticate(string uname, string pass)
        {
            var user = from u in db.Users
                       where u.Username.Equals(uname)
                       && u.Password.Equals(pass)
                       select u;
            if (user != null) return user.SingleOrDefault();
            return null;

        }
    }
}