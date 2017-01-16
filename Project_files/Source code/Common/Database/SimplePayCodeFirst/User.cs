using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SimplePayCodeFirst
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public bool IsAdmin { get; set; }
        [Required, MaxLength(40)]
        public string Name { get; set; }
        [Required, MaxLength(40)]
        public string Surname { get; set; }
        [Required, MaxLength(40)]
        public string Login { get; set; }
        [Required, MaxLength(14)]
        public string Password { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(17)]
        public string Phone { get; set; }
        [MaxLength(50)]
        public string Address { get; set; }
        public DateTime DateTime { get; set; }


        public virtual List<Transaction> Transactions { get; set; }
        public virtual List<Account> Accounts { get; set; }
    }
}
