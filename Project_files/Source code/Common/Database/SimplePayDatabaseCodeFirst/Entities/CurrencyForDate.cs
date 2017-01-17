using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class CurrencyForDate
    {
        public int ID { get; set; }
        public DateTime DateTime { get; set; }
        public double Multiplier { get; set; }
        public Currency Currency { get; set; }
    }
}
