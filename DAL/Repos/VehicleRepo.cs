using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repos
{
    public class VehicleRepo : Repo, IRepo<Vehicle, int, bool>
    {
        public bool Create(Vehicle obj)
        {
            db.Vehicles.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var ex = Get(id);
            db.Vehicles.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Vehicle> Get()
        {
            return db.Vehicles.ToList();
        }

        public Vehicle Get(int id)
        {
            return db.Vehicles.Find(id);
        }

        public bool Update(Vehicle obj)
        {
            var ex = Get(obj.Id);
            db.Entry(ex).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
