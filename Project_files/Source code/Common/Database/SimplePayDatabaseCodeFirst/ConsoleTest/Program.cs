
using Interfaces;
using Repositories;
using SimplePay.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ICurrencyRepo CurrencyRepo = new CurrencyRepo();

            //CurrencyRepo.Add(new Currency() { FullName = "Dolar", ShortName = "USD" });
            //CurrencyRepo.Add(new Currency() { FullName = "Grivna", ShortName = "UAH" });
            var v = new Currency() { FullName = "Dolar", ShortName = "USD" };
            //CurrencyRepo.Add(v);


           //CurrencyRepo.Delete(CurrencyRepo.SelectById(5));
            var currencies = CurrencyRepo.GetAll();
            foreach(var c in currencies)
            {
                Console.WriteLine(c.ShortName);
                Console.WriteLine(c.FullName);
                Console.WriteLine("-----------------------------");
            }


            ICurrencyForDateRepo CurrencyForDateRepo = new CurrencyForDateRepo();
            CurrencyForDateRepo.Add(new CurrencyForDate() { DateTime = DateTime.UtcNow, Multiplier = 28.8, Currency = v });

            var currFD = CurrencyForDateRepo.GetAll();
            foreach (var c in currFD)
            {
                Console.WriteLine(c.DateTime);
                Console.WriteLine(c.Multiplier);
                Console.WriteLine(c.Currency.ID + " " + c.Currency.ShortName + " " + c.Currency.FullName );
                Console.WriteLine("-----------------------------");
            }


            IAccountRepo acctREepo = new AccountRepo();

            acctREepo.FilterAccounts(a => a.ID > 5, 1, 5);
            Console.ReadKey();
        }
    }
}
