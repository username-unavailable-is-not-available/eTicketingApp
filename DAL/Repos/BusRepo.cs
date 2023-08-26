using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repos
{
    public class BusRepo : Repo, IRepo<Bus, int, bool>
    {
        public bool Create(Bus obj)
        {
            db.Buses.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var exobj = Get(id);
            db.Buses.Remove(exobj);
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
            throw new NotImplementedException();
        }
    }
}
