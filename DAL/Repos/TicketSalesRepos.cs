using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class TicketSalesRepos : Repo, IRepo<TicketSales, int, bool>
    {
        public bool Add(TicketSales obj)
        {
            db.TicketSales.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var ex = Get(id);
            db.TicketSales.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<TicketSales> Get()
        {
            return db.TicketSales.ToList();
        }

        public TicketSales Get(int id)
        {
            return db.TicketSales.Find(id);
        }

        public bool Update(TicketSales obj)
        {
            var ex = Get(obj.Id);
            db.Entry(ex).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
