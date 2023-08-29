using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class RouteAndScheduleRepos : Repo, IRepo<RouteAndSchedule, int, bool>
    {
        public bool Add(RouteAndSchedule obj)
        {
            db.RouteAndSchedules.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var ex = Get(id);
            db.RouteAndSchedules.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<RouteAndSchedule> Get()
        {
            return db.RouteAndSchedules.ToList();
        }

        public RouteAndSchedule Get(int id)
        {
            return db.RouteAndSchedules.Find(id);
        }

        public bool Update(RouteAndSchedule obj)
        {
            var ex = Get(obj.Id);
            db.Entry(ex).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
