using DAL.EF.Models;
using DAL.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repos
{
    public class TicketManageRepo : Repo, IRepo<TicketManage, int, bool>
    {
        public bool Create(TicketManage obj)
        {
            db.Tickets.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var ex = Get(id);
            db.Tickets.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<TicketManage> Get()
        {
            return db.Tickets.ToList();
        }

        public TicketManage Get(int id)
        {
            return db.Tickets.Find(id);
        }

        public bool Update(TicketManage obj)
        {
            var ex = Get(obj.Id);
            db.Entry(ex).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}