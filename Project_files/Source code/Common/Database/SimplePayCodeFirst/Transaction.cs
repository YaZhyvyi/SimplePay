using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace SimplePayCodeFirst
{
    public class Transaction
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
        [MaxLength(40)]
        public string ToSomeone { get; set; }
        [Required]
        public double Summa { get; set; }
        [MaxLength(255)]
        public string Comment { get; set; }


        [Required]
        public virtual CurrencyForDate CurrencyForDate { get; set; }
        [Required]
        public virtual User FromUser { get; set; }
        public virtual User ToUser { get; set; }
    }
}
