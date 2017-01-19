using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Net;
using System.ServiceModel.Description;

namespace SimplePayServices.DateObjects
{
   [DataContract]
   public class Account
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string PersonalNumber { get; set; }
        [DataMember]
        public double Balance { get; set; }
        [DataMember]
        public Currency Currency { get; set; }
        [DataMember]
        public User User { get; set; }
        [DataMember]
        public List<Transaction> Transactions { get; set; }
    }
    
}
