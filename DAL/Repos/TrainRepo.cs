using DAL.EF.Models;
using DAL.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repos
{
    public class TrainRepo : Repo, IRepo<Train, int, bool>
    {
        public List<Train> Get()
        {
            return db.Trains.ToList();
        }

        public Train Get(int id)
        {
            return db.Trains.Find(id);
        }

        public bool Create(Train obj)
        {
            db.Trains.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(Train obj)
        {
            var ex = Get(obj.Id);
            db.Entry(ex).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var ex = Get(id);
            db.Trains.Remove(ex);
            return db.SaveChanges() > 0;
        }
    }
}
