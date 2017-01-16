using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePayCodeFirst
{
    public class Currency
    {
        [Key]
        public int ID { get; set; }
        [Required, MinLength(3), MaxLength(3)]
        public string ShortName { get; set; }
        [Required, MaxLength(25)]
        public string FullName { get; set; }


       

    }
}
