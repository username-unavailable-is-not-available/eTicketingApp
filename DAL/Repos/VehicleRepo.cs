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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
