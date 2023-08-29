using DAL.EF.Models;
using DAL.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repos
{
    internal class AirplaneRepo : Repo, IRepo<Airplane, int, bool>
    {
        public List<Airplane> Get()
        {
            return db.Airplanes.ToList();
        }

        public Airplane Get(int id)
        {
            return db.Airplanes.Find(id);
        }

        public bool Create(Airplane obj)
        {
            db.Airplanes.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(Airplane obj)
        {
            var ex = Get(obj.Id);
            db.Entry(ex).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var ex = Get(id);
            db.Airplanes.Remove(ex);
            return db.SaveChanges() > 0;
        }
    }
}
