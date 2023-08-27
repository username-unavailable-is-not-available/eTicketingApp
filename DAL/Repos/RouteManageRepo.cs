using DAL.EF.Models;
using DAL.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repos
{
    public class RouteManageRepo : Repo, IRepo<RouteManage, int, bool>
    {
        public bool Create(RouteManage obj)
        {
            db.Routes.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var ex = Get(id);
            db.Routes.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<RouteManage> Get()
        {
            return db.Routes.ToList();
        }

        public RouteManage Get(int id)
        {
            return db.Routes.Find(id);
        }

        public bool Update(RouteManage obj)
        {
            var ex = Get(obj.Id);
            db.Entry(ex).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}