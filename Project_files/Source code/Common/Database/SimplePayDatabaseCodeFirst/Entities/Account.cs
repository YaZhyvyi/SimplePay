using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Account
    {
        public int ID { get; set; }
        public string PersonalNumber { get; set; }
        public double Balance { get; set; }
        public Currency Currency { get; set; }
        public User User { get; set; }
    }
}
