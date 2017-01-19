using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace SimplePayServices.DateObjects
{
    [DataContract(Name = "TransactionType")]
    public enum TransactionType
    {
        [EnumMember]
        Payment, //оплата товару/послуги
        [EnumMember]
        Transfer, //переказ коштів іншому користувачу
        [EnumMember]
        Refill, //поповнити рахунок
        [EnumMember]
        Withdraw //зняти кошти з рахунку
    }
    [DataContract]
    public class Transaction
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public DateTime TransactionDate { get; set; }
        [DataMember]
        public TransactionType TransactionType { get; set; }
        [DataMember]
        public string ToSomeone { get; set; }
        [DataMember]
        public double Summa { get; set; }
        [DataMember]
        public string Comment { get; set; }
        [DataMember]
        public CurrencyForDate CurrencyForDate { get; set; }
        [DataMember]
        public Account FromUserAccount { get; set; }
        [DataMember]
        public Account ToUserAccount { get; set; }
    }
}
