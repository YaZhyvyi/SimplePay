using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace SimplePayCodeFirst
{
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
}
