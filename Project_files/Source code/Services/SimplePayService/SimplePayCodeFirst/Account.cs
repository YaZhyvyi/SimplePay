using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimplePayCodeFirst
{
    public class Account
    {
        public int ID { get; set; }
        public int PersonalNumber { get; set; }
        public double Balance { get; set; }

        public virtual Currency Currency { get; set; }
        public virtual User User { get; set; }
    }
}
