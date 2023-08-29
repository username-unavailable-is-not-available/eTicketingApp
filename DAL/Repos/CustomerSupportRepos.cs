using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class CustomerSupportRepos : Repo, IRepo<CustomerSupport, int, bool>
    {
        public bool Add(CustomerSupport obj)
        {
            db.customerSupports.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var ex = Get(id);
            db.customerSupports.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<CustomerSupport> Get()
        {
            return db.customerSupports.ToList();
        }

        public CustomerSupport Get(int id)
        {
            return db.customerSupports.Find(id);
        }

        public bool Update(CustomerSupport obj)
        {
            var ex = Get(obj.Id);
            db.Entry(ex).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    
    }
}
