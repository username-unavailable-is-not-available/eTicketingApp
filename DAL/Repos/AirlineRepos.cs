using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class AirlineRepos : Repo, IRepo<Airline, int, bool>
    {
        public bool Add(Airline obj)
        {
            db.Airlines.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var ex = Get(id);
            db.Airlines.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Airline> Get()
        {
            return db.Airlines.ToList();
        }

        public Airline Get(int id)
        {
            return db.Airlines.Find(id);
        }

        public bool Update(Airline obj)
        {
            var ex = Get(obj.Id);
            db.Entry(ex).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
