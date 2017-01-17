using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Transaction
    {
        public int ID { get; set; }
        public DateTime DateTime { get; set; }
        public string ToSomeone { get; set; }
        public double Summa { get; set; }
        public string Comment { get; set; }
        public CurrencyForDate CurrencyForDate { get; set; }
        public User FromUser { get; set; }
        public User ToUser { get; set; }
    }
}
