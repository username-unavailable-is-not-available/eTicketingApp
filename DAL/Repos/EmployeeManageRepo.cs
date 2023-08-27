using DAL.EF.Models;
using DAL.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repos
{
    public class EmployeeManageRepo : Repo, IRepo<EmployeeManage, int, bool>
    {
        public bool Create(EmployeeManage obj)
        {
            db.Employees.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var ex = Get(id);
            db.Employees.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<EmployeeManage> Get()
        {
            return db.Employees.ToList();
        }

        public EmployeeManage Get(int id)
        {
            return db.Employees.Find(id);
        }

        public bool Update(EmployeeManage obj)
        {
            var ex = Get(obj.Id);
            db.Entry(ex).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}