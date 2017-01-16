using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace SimplePayCodeFirst
{
    public class Account
    {
        [Key]
        public int ID { get; set; }
        [Required, MinLength(12), MaxLength(12)]
        public string PersonalNumber { get; set; }
        [Required]
        public double Balance { get; set; }


        [Required]
        public  Currency Currency { get; set; }
        [Required]
        public virtual User User { get; set; }
    }
}
