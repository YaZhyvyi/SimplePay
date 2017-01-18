using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLibrary.DataModels
{
    public class Account
    {
        [Key]
        public int ID { get; set; }
        [Required, MinLength(12), MaxLength(12), Index(IsUnique = true)]
        public string PersonalNumber { get; set; }
        [Required]
        public double Balance { get; set; }


        [Required]
        public virtual Currency Currency { get; set; }
        [Required]
        public virtual User User { get; set; }

        public virtual List<Transaction> Transactions { get; set; }
    }

    public class Currency
    {
        [Key]
        public int ID { get; set; }
        [Required, MinLength(3), MaxLength(3), Index(IsUnique = true)]
        public string ShortName { get; set; }
        [Required, MaxLength(25), Index(IsUnique = true)]
        public string FullName { get; set; }
    }

    public class CurrencyForDate
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
        [Required]
        public double Multiplier { get; set; }
        [Required]
        public virtual Currency Currency { get; set; }

    }

    public enum TransactionType
    { 
        Payment, //оплата товару/послуги
        Transfer, //переказ коштів іншому користувачу
        Refill, //поповнити рахунок
        Withdraw //зняти кошти з рахунку
    }

    public class Transaction
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public TransactionType TransactionType { get; set; }
        [Required]
        public DateTime TransactionDate { get; set; }
        [Required]
        public double Summa { get; set; }
        [MaxLength(1000)]
        public string Comment { get; set; }


        [Required]
        public virtual CurrencyForDate CurrencyForDate { get; set; }
        [Required]
        public virtual Account FromUserAccount { get; set; }
        public virtual Account ToUserAccount { get; set; }
    }

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
        [Required, MaxLength(40), Index(IsUnique = true)]
        public string Login { get; set; }
        [Required, MaxLength(14)]
        public string Password { get; set; }
        [MaxLength(50), Index(IsUnique = true)]
        public string Email { get; set; }
        [Required]
        [RegularExpression(@"^\([0-9]{3}\)[0-9]{3}-[0-9]{2}-[0-9]{2}$", ErrorMessage = "Number should match the following pattern: (xxx)xxx-xx-xx")]
        public string Phone { get; set; }
        [MaxLength(50)]
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }


        
        public virtual List<Account> Accounts { get; set; }
    }

}
