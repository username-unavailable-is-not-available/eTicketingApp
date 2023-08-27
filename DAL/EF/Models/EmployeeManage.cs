using System.Collections.Generic;

namespace DAL.EF.Models
{
    public class EmployeeManage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public virtual ICollection<FinanceManage> Finances { get; set; }
        public EmployeeManage()
        {
            Finances = new List<FinanceManage>();
        }
    }
}