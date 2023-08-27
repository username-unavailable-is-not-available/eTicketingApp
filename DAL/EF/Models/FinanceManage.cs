using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.EF.Models
{
    public class FinanceManage
    {
        public int Id { get; set; }
        public decimal Salary { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public EmployeeManage Employee { get; set; }
    }
}