using DAL.EF.Models;
using DAL.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repos
{
    public class FinanceManageRepo : Repo, IRepo<FinanceManage, int, bool>
    {
        public bool Create(FinanceManage obj)
        {
            db.Finances.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var ex = Get(id);
            db.Finances.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<FinanceManage> Get()
        {
            return db.Finances.ToList();
        }

        public FinanceManage Get(int id)
        {
            return db.Finances.Find(id);
        }

        public bool Update(FinanceManage obj)
        {
            var ex = Get(obj.Id);
            db.Entry(ex).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}