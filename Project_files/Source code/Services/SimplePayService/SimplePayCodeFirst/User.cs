﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimplePayCodeFirst
{
    public class User
    {
        public int ID { get; set; }
        public bool IsAdmin { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime DateTime { get; set; }


        public virtual List<Transaction> Transactions { get; set; }
        public virtual List<Account> Accounts { get; set; }
    }
}
