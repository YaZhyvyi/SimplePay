using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace SimplePayServices.DateObjects
{
    [DataContract]
   public class CurrencyForDate
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public DateTime DateTime { get; set; }
        [DataMember]
        public double Multiplier { get; set; }
        [DataMember]
        public Currency Currency { get; set; }
    }
}
