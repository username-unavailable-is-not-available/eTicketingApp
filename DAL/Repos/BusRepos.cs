using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class BusRepos : Repo, IRepo<Bus, int, bool>
    {
        public bool Add(Bus obj)
        {
            db.Buses.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var ex = Get(id);
            db.Buses.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Bus> Get()
        {
            return db.Buses.ToList();
        }

        public Bus Get(int id)
        {
            return db.Buses.Find(id);
        }

        public bool Update(Bus obj)
        {
            var ex = Get(obj.Id);
            db.Entry(ex).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
