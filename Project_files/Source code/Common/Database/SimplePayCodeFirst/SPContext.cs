using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePayCodeFirst
{
    public class SPContext : DbContext
    {
        public SPContext()
            : base("SPContext")
        { }
          
        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<CurrencyForDate> CurrencyForDates { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}
