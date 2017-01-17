using Interfaces;
using Repositories;
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

            //CurrencyRepo.Add(new Entities.Currency() { FullName = "Dolar", ShortName = "USD" });
            //CurrencyRepo.Add(new Entities.Currency() { FullName = "Grivna", ShortName = "UAH" });


           //CurrencyRepo.Delete(CurrencyRepo.SelectById(5));
            var currencies = CurrencyRepo.GetAll();
            foreach(var c in currencies)
            {
                Console.WriteLine(c.ShortName);
                Console.WriteLine(c.FullName);
                Console.WriteLine("-----------------------------");
            }
        }
    }
}
