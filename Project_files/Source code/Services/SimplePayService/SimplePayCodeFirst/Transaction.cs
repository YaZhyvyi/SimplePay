using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimplePayCodeFirst
{
    public class Transaction
    {
        public int ID { get; set; }
        public DateTime DateTime { get; set; }
        public string ToSomeone { get; set; }
        public double Summa { get; set; }
        public string Comment { get; set; }


        public virtual CurrencyForDate CurrencyForDate { get; set; }
        public virtual User FromUser { get; set; }
        public virtual User ToUser { get; set; }
    }
}
