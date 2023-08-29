using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class TicketRepos : Repo, IRepo<Ticket, int, bool>
    {
        public bool Add(Ticket obj)
        {
            db.tickets.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var ex = Get(id);
            db.tickets.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Ticket> Get()
        {
            return db.tickets.ToList();
        }

        public Ticket Get(int id)
        {
            return db.tickets.Find(id);
        }

        public bool Update(Ticket obj)
        {
            var ex = Get(obj.Id);
            db.Entry(ex).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
