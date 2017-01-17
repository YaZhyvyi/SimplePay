using DatabaseLibrary.DataModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLibrary.Context
{
    public class SPContext : DbContext
    {
        public SPContext()
            : base("SPContext")
        {
            Database.SetInitializer<SPContext>(null);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<CurrencyForDate> CurrencyForDates { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}
