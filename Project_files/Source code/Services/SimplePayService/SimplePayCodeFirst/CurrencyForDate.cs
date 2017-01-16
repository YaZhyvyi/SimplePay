using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimplePayCodeFirst
{
    public class CurrencyForDate
    {
        public int ID { get; set; }
        public DateTime DateTime { get; set; }
        public double Multiplier { get; set; }

        public virtual Currency Currency { get; set; }
        public int CurrencyID { get; set; }


    }
}
