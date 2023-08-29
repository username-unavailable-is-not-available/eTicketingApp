using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace DAL.EF.Models
{
    public class Token
    {
        public int Id { get; set; }
        public string TokenKey { get; set; }
        [ForeignKey("User")]
        public string Username { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ExpiredAt { get; set; }
        public virtual User User { get; set; }
    }
}