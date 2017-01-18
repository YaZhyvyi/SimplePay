using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePay.DataTransferObjects
{
    public enum TransactionType
    {
        Payment, //оплата товару/послуги
        Transfer, //переказ коштів іншому користувачу
        Refill, //поповнити рахунок
        Withdraw //зняти кошти з рахунку
    }
    public class Transaction
    {
        public int ID { get; set; }
        public DateTime TransactionDate { get; set; }
        public TransactionType TransactionType { get; set; }
        public string ToSomeone { get; set; }
        public double Summa { get; set; }
        public string Comment { get; set; }
        public CurrencyForDate CurrencyForDate { get; set; }
        public Account FromUserAccount { get; set; }
        public Account ToUserAccount { get; set; }
    }
}
